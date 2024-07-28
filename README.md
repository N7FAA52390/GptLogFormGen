# GptLogFormGen

### **Welcome to the GptLogFormGen Repository!**

## Table of Contents
- [Introduction](#introduction)
- [Building Instructions](#building-instructions)
- [Usage](#usage)
- [Acknowledgements](#acknowledgements)
- [License](#license)
- [Contact](#contact)

## Introduction

GptLogFormGen is a C# application with a graphical user interface designed to help you manually log and organize your conversations with GPT. The application allows you to input message pairs (input and output) and generate a Markdown file for record-keeping. This tool is particularly useful for those who want to maintain a structured archive of their interactions without violating any terms of service that prohibit automated content extraction.

The application offers various options, including setting the number of interaction records, customizing the conversation title, specifying an output file path, and optionally including a utilities section in the output file.

By using GptLogFormGen, you can ensure your important GPT conversations are well-documented and easily accessible in a neat and organized format.

## Building Instructions

To build the GptLogFormGen application, follow these steps:

1. Clone the repository to your local machine:
   ```bash
   git clone https://github.com/N7FAA52390/GptLogFormGen
   ```

2. Navigate into the repository directory:
   ```bash
   cd GptLogFormGen
   ```

3. Navigate to the solution file directory:
   ```bash
   cd src/GptLogFormGen
   ```

4. Build the project:
   ```bash
   dotnet publish src/GptLogFormGen/GptLogFormGen/GptLogFormGen.sln -c Release -r win-x64 --self-contained -p:PublishSingleFile=true -p:IncludeAllContentForSelfExtract=true -o build

   ```

## Usage

**Note:** The following usage instructions apply to when the project is freshly built. The executable file can be moved to any directory and will still function correctly.

1. Navigate to the `build` directory from the project root directory:
   ```bash
   cd build
   ```

2. Run the application:
   ```bash
   ./GptLogFormGen.exe
   ```

3. Fill in the required fields in the form:
   - **Number of Interactions:** Enter the number of interaction records (i.e., QA message pairs).
   - **Conversation Title:** Enter the title of the conversation.
   - **Conversation Link:** Enter a link to the conversation (optional).
   - **Include Utils Section:** Check this box to include the utilities section in the output file (optional).

4. Click the "Create File" button to generate the Markdown file. The file will be saved in the same directory as the executable.

## Acknowledgements
- **ChatGPT:** Powered by OpenAI, specifically ChatGPT-4. Files in this project vary from being completely AI-generated to completely human-generated. The term Content, and other relevant definitions, can be observed on [The OpenAI TOS page](https://openai.com/policies/terms-of-use#using-our-services).

## License
This project is licensed under the [MIT LICENSE](LICENSE) - see the file for details.

## Contact
Axel Gauti Guðmunds Fanneyjar - [@axelgauti](https://twitter.com/axelgauti) - axel@axelgauti.is