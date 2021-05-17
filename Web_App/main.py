import eel
import wave

eel.init('web')

@eel.expose
def steg(song_path,message):

    print(message,song_path)
    # Đọc audio file
    song = wave.open(song_path, mode='rb')

    # Đọc frames và chuyển sang byte array
    frame_bytes = bytearray(list(song.readframes(song.getnframes())))
    # print (binascii.hexlify(frame_bytes))
    # print("@@"+frame_bytes+"@@")

    # Append dummy data to fill out rest of the bytes. Receiver shall detect and remove these characters.
    message = message + int((len(frame_bytes)-(len(message)*8*8))/8) *'#'
    #print(int((len(frame_bytes)-(len(message)*8*8))/8))
    # Convert text to bit array
    bits = list(map(int, ''.join([bin(ord(i)).lstrip('0b').rjust(8,'0') for i in message])))

    # Replace LSB of each byte of the audio data by one bit from the text bit array
    for i, bit in enumerate(bits):
        frame_bytes[i] = (frame_bytes[i] & 254) | bit
    # Get the modified bytes
    frame_modified = bytes(frame_bytes)

    new_song_path = 'embedded-' + song_path
    # Write bytes to a new wave audio file
    fd = wave.open(new_song_path, 'wb')
    fd.setparams(song.getparams())
    fd.writeframes(frame_modified)
    
    fd.close();
    song.close()
    
    return "success"

@eel.expose
def recover(filename):
    song = wave.open(filename, mode='rb')
    # Convert audio to byte array
    frame_bytes = bytearray(list(song.readframes(song.getnframes())))

    # Extract the LSB of each byte
    extracted = [frame_bytes[i] & 1 for i in range(len(frame_bytes))]
    # Convert byte array back to string
    string = "".join(chr(int("".join(map(str,extracted[i:i+8])),2)) for i in range(0,len(extracted),8))
    # Cut off at the filler characters
    decoded = string.split("###")[0]

    # Print the extracted text
    print("Sucessfully decoded: "+decoded)
    song.close()
    
    return decoded;

eel.start('main.html')
