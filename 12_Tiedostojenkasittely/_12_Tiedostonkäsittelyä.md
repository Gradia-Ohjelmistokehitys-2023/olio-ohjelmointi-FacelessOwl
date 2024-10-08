# Tiedostojen käsittely C#-kielessä  
  
https://www.c-sharpcorner.com/blogs/filestream-class-in-c-sharp1/


https://www.c-sharpcorner.com/article/working-with-c-sharp-streamreader/

## Osaamistavoitteita
- Tiedostojen käsittely
- Tiedostojen sisällön käsittely
- FileStream
- BufferedStream
- Readers and Writers
- Serialisointi:
binary ja JSON
https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/serialization/  
  
  
### 12.1 Luo luokka Tiedosto

- Tee pääohjelma (main), joka kysyy tiedoston nimen ja 
tulostaa tiedon siitä onko annetun niminen tiedosto olemassa.

Esimerkki:

Anna tiedoston nimi: foo.txt
Tiedosto foo.txt on olemassa.

Anna tiedoston nimi: c:/autoexec.bat
Tiedostoa c:/autoexec.bat ei ole olemassa.


### 12.2 Jatka tehtävän 12.1 pääohjelmaa:
- luo ja avaa tekstitiedosto teksti1.txt siten, että sen sisältö tyhjenee, kun se avataan.
- Kirjoita tiedostoon rivi ”Hello world!”
- Kirjoita tiedostoon rivi ”Uusi rivi tässä.”
- sulje tiedosto
Tarkista tiedoston sisältö.

### 12.3
- tarkista ennen avaamista onko teksti1.txt olemassa. Tee 12.1 -kohdan pääohjelman koodista tarvittaessa oma metodi +bool OnOlemassa(string nimi);
Jos tiedosto on olemassa:
- avaa tekstitiedosto teksti1.txt
- lue rivit rivi kerrallaan a) taulukoksi - Array b) listaksi - List c) merkkijonoksi (string)
- tulosta a, b ja c -kohtien tiedot
- sulje tiedosto

### 12.4
- avaa tekstitiedosto teksti1.txt peräänkirjoitusta varten. Tiedoston vanha sisältö säilyy avattaessa ja kirjoittaminen alkaa tiedoston lopusta.
- tulosta tiedoston jo olemassa oleva sisältö. Tee kohdan 12.3. rivienlukemiskoodista tarvittaessa yksi tai useampi uusi metodi.
- lisää tiedostoon rivi ”Huuhaa!”
- sulje tiedosto
- avaa tekstitiedosto uudelleen vain lukemista varten
- lue ja tulosta tiedoston sisältö rivi kerrallaan
- sulje tiedosto

### 12.5 
- avaa tektitiedosto teksti1.txt lukemista varten
- lue tiedoston sisältö merkki (char) kerrallaan ja tulosta luetut merkit pilkulla erotettuna.
- sulje tiedosto.
Malli:
H,e,l,l,o, ,w,o,r,l,d,!,

### 12.6. 
-Avaa (luo) tiedosto munbinaari.bin kirjoittamista varten. Vanha sisältö saa nollautua avattaessa.  
-kirjoita tiedostoon liukuluku 3,14159265 ja kokonaisluku -1  
-sulje tiedosto  
-avaa tiedosto  
-lue tiedostosta arvot float f ja int i ja tulosta ne.  
-sulje tiedosto  
-tarkastele tiedoston sisältöä tekstieditorilla (notepad tms.) ja kerro mitä näet. Vihje: ei saa näkyä 3,14159265-1  

### 12.7
Tee ohjelma, joka tulostaa hakemiston sisällön.
Esim:  
.
..
munbinaari.bin


