# Running Process Checker (C# for Windows)
_Checks if a process is running by its name and runs the selected file if not._

## Running and compiling
1. Clone the repository on your device.
2. Compile the project and run the file in the folder `RunningProcessChecker/bin/Debug/RunningProcessChecker.exe`.
3. If you want to run programs as administrator, the `RunningProcessChecker.exe` will need to be run as administrator too.

## Usage
### Step 1
Write the name of the process that the program will monitor without ".exe" file extension.
> Moment. The name of the running process you enter may not match the program you are running.

![image](https://user-images.githubusercontent.com/94769428/160679732-11bc74c3-47e6-4b3e-a467-0295715303eb.png)

When you enter a name, the program will check running processes. If the process is already running, and the name is correct, a green "process found" message will appear below.

![image](https://user-images.githubusercontent.com/94769428/160680161-d2843423-612a-4121-b8f9-abec11b4bc7a.png)

### Step 2

To run the program as an administrator, you need to check the box.

![image](https://user-images.githubusercontent.com/94769428/160680661-9ee6fd99-5ed9-4901-b1bd-5c796893fce7.png)

### Step 3
You are already on target!
Now you need to click on the "Okay, lets go" button and the program will prompt you to select a file that will be launched if the process with the name specified in `Step 1` is not found.
The program will check every 2 seconds whether the specified process is running.
> Moment. You can choose any file extension. The selected file will open in the default program (associated on your system by the file extension).

All done!
