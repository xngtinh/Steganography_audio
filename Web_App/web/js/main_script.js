
function perform_steg(){
    var song_path = document.getElementById("song_path").files[0].name;
    var message = document.getElementById('message').value;
    eel.steg(song_path,message)(function(ret){
        Swal.fire({
          position: 'top-end',
          icon: 'success',
          title: 'Your work has been saved',
          showConfirmButton: false,
          timer: 1500
        })
        document.getElementById("song_path").value = "";
        document.getElementById('message').value = "";
    });
}
function recover_steg(){
    var file = document.getElementById("file").files[0].name;
    console.log(file);
    eel.recover(file)
    (function(ret){
        document.getElementById("Demessage").value = ret;
    });
}
function openCity(evt, cityName) {
  var i, tabcontent, tablinks;
  tabcontent = document.getElementsByClassName("tabcontent");
  for (i = 0; i < tabcontent.length; i++) {
    tabcontent[i].style.display = "none";
  }
  tablinks = document.getElementsByClassName("tablinks");
  for (i = 0; i < tablinks.length; i++) {
    tablinks[i].className = tablinks[i].className.replace(" active", "");
  }
  document.getElementById(cityName).style.display = "block";
  evt.currentTarget.className += " active";
}
