# 🔐 RSA WinForms Application

## 📌 Introduction
This is an RSA encryption algorithm simulation application built with C# WinForms, developed for a Computer Network Security course project. The program demonstrates the process of key generation, encryption, and decryption of text data using the RSA algorithm, thereby supporting learning and research of fundamental public-key cryptography concepts.

## 🎯 Objectives
* Understand the working principles of the RSA algorithm
* Practice RSA key generation (p, q, n, φ(n), e, d)
* Perform text encryption and decryption
* Apply cryptographic knowledge to practical programming with WinForms

## 🛠 Technologies Used
* **Language:** C#
* **Interface:** Windows Forms (WinForms)
* **Library:** `System.Numerics.BigInteger`
* **Algorithms:**
   * RSA
   * Miller–Rabin (primality testing)
   * Extended Euclidean (modular inverse calculation)

## ⚙️ Main Features
* Input or automatically generate prime numbers `p`, `q`
* Generate RSA keys:
   * Public key `(e, n)`
   * Private key `(d, n)`
* Encrypt text using public key
* Decrypt text using private key
* Read data from `.txt` files
* Save encryption/decryption results to files

## 📂 How to Run the Program

### Method 1: Run from Source Code
1. Clone the source code from GitHub:
```bash
git clone https://github.com/BooBoo0531/RSA-WinForms.git
```

2. Open the `RSA-App.sln` file with Visual Studio

3. Build and run the program (`Ctrl + F5`)

### Method 2: Run Executable File
Run the `.exe` file directly in the publish folder (if available).

## 📸 Screenshots
<img width="975" height="637" alt="image" src="https://github.com/user-attachments/assets/e1c6080d-f441-4626-acf4-2a9ad021541a" />


## 🔧 System Requirements
* Windows 7 or higher
* .NET Framework 4.7.2 or higher
* Visual Studio 2019 or higher (for development)

## 📖 Usage Guide

### 1. Generate Keys
- Enter two prime numbers `p` and `q`, or click "Generate" to automatically create them
- Click "Generate Keys" to create public and private key pairs

### 2. Encrypt Text
- Enter the plaintext you want to encrypt
- Click "Encrypt" to encode the message using the public key

### 3. Decrypt Text
- Use the encrypted text from the previous step
- Click "Decrypt" to decode the message using the private key

### 4. File Operations
- Use "Open File" to read plaintext from `.txt` files
- Use "Save File" to save encryption/decryption results

## ⚠️ Important Notes
* This application is for **simulation and educational purposes only**
* Does not implement advanced security mechanisms such as padding (OAEP)
* **Not intended for production environments** with high security requirements
* Key sizes used may be smaller than industry standards for demonstration purposes
* **The application interface is in Vietnamese**

## 🤝 Contributing
Contributions, issues, and feature requests are welcome! Feel free to check the [issues page](https://github.com/BooBoo0531/RSA-WinForms/issues).

## 👨‍🎓 Project Information
* **Course:** Computer Network Security - NT101.Q11
* **Topic:** RSA Algorithm Simulation
* **Format:** WinForms Application
* **Author:** BooBoo0531
* **Institution:** University of Information Technology - UIT


## 📄 License
This project is licensed for educational and research purposes only.

## 📧 Contact
For questions or feedback, please contact:
* GitHub: [@BooBoo0531](https://github.com/BooBoo0531)
* Email: heyyou345612@gmail.com
