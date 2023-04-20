﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sercurity
{
     public class Vigernere
     {
          #region property
          public string key { get; set; }
          public string plainText { get; set; }
          public string cipherText { get; set; }
          #endregion
          public Vigernere() 
          {
               key = "Unknown author";
               plainText = "A new book";
               cipherText = "Unknown publisher";
          }
     public Vigernere(string s)
          {
               key = s.ToUpper();
          }
          string chuoi = "ABCDEFGHIKLMNOPQRSTUVWXYZ";
          public int[] chuoi_mangchiso(string s)
          {
               int[] mang = new int[s.Length];
               for (int i = 0; i < s.Length; i++)
                    mang[i] = chuoi.IndexOf(s[i]);
               return mang;
          }
          public string chiso_chuoi(int[] a)
          {
               string s = "";
               for (int i = 0; i < a.Length; i++)
                    s += chuoi[a[i]];
               return s;
          }
          public String MaHoa()
          {
               plainText = plainText.ToUpper();
               int[] p = chuoi_mangchiso(plainText);
               int[] k = chuoi_mangchiso(key);

               int[] kq = new int[plainText.Length];
               for (int i = 0, j = 0; i < plainText.Length; i++)
               {
                    kq[i] = (p[i] + k[j]) % chuoi.Length;
                    j = ++j % k.Length;
               }
               cipherText = chiso_chuoi(kq);
               return cipherText;
          }
          public String GiaiMa()
          {
               int[] c = chuoi_mangchiso(cipherText);
               int[] k = chuoi_mangchiso(key);

               int[] kq = new int[cipherText.Length];
               for (int i = 0, j = 0; i < cipherText.Length; i++)
               {
                    kq[i] = (c[i] - k[j]) % chuoi.Length;
                    if (kq[i] < 0)
                         kq[i] = (c[i] + (chuoi.Length - k[j])) % chuoi.Length;
                    j = ++j % k.Length;
               }
               plainText = chiso_chuoi(kq);
               return plainText;
          }
     }
}
