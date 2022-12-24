# RSA-Digital-Signature-Remake
Version for normal users
How to use?
Create RSA digital signature
- Step 1: choose size key default 1024.
- Step 2: choose file you want make signature.
- Step 3: click button "Create Digital Signature" and name for folder signature.
- Step 4: your signature will be create and place in desktop, you can access to this folder and send file signature.zip 
*Note: do not try to extract manual file signature.zip.

Vertification
- Step 1: import file signature.zip to area signature file.
- Step 2: choose one of option desktop and elective, this is locate extract file digital signature after vertification.
- Step 3: click button "Vertification Digital Signature".
*Note: Inside file signature.zip contain 3 file:
  - signature file ".qvst".
  - file "PublicKey.xml".
  - your file are used to make signature.

Version 2(23/12/2022)
- Optimal read file algorithm.
- For everyone who want check state "vertification failed":
    *Extract Signature.zip have been created.
    *Replace origin file with any file or rewrite it.
    *Zip 3 file: PublicKey.xml, file.qvst(signature file) and origin file (replaced).NOTE: zip 3 file, NOT zip folder contain 3 file!
    *Uing feature Vertification Signature,import zip file above and click button Vertification Signature, you will see warning red line.
