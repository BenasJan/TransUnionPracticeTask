# Caesar cipher
Caesar cipher in blazor WASM

To launch the project:
1. Open TransUnionPracticeTask.sln in Visual Studio
2. Press Ctrl+F5 to launch a local development server
3. Go to https://localhost:44349/

At first I thought of the traditional way to implement Caesar cipher, for example:
If I need to encipher the letter 'Z' by shifting it by 3 steps, I would get 'C'.
However I soon realised that I do not need to loop through the alphabet in order to
make the cipher fully functional. I just need to return the character that is encoded 
3 steps higher. Although this way of implementing Caesar cipher seemed a bit cheaty to me
so I implented it in both ways.

![](/Screenshots/encipher-screenshot.png?raw=true)
The text is enciphered in both ways:
1. By simply shifting every character by the amount of steps
2. Shifting every character by the amount of steps and looping through the alphabet when necessary (in the looping way, any character that is not a letter is left as is)

![](/Screenshots/decipher-screenshot.png?raw=true)

![](/Screenshots/decipher-screenshot-looped.png?raw=true)
