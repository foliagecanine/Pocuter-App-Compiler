# Pocuter App Compiler

<img src="https://user-images.githubusercontent.com/45408062/234443775-5d76f657-ea4b-4db0-9381-d47b0c589df4.png" width=200 alt="Demonstration of Pocuter App Compiler" />

This project is neither affiliated with nor endorsed by Pocuter GmbH.

-----

## Download

Check the [Releases](https://github.com/foliagecanine/Pocuter-App-Compiler/releases/) for downloads.

## Usage

1. Create a Pocuter app using the Arduino IDE. Ideally use the BaseApp or another app from the built-in [Pocuter One Apps](https://github.com/pocuter/Pocuter-One_Apps) as a base so that the app can exit properly.
2. Open `Pocuter App Compiler.exe`.
3. Click the [Browse...] button under the **App Project** heading and select the folder containing your sketch from Step 1.
4. Give your app a name in the **App Name** box.
5. Select a version number for your app in the **App Version** box. It can go from 0.0.0 to 255.255.255.
6. Choose an App ID for your app and enter it into the **App ID** box. According to Pocuter this should be a number greater than 100000 or the number assigned for the app store.
7. Enter in the author of the app in the **App Author** box.
8. (Optional) Create a 16x16 icon for your app, click the [Browse...] button under the **App Icon** heading and select the icon.
9. Choose one or both of the following:
*  Select **Output to Apps Folder** and click [Browse...] to browse for a folder to save the app.
*  Select **Install on Pocuter Wirelessly** and see the [Installing Wirelessly](#Installing-Wirelessly) section for the additional steps.
10. Click **Compile App**. It will automatically compile the code, generate the app, and export it using the selected method(s).

## Installing Wirelessly

If you wish to wirelessly transfer and run your app on your Pocuter, do the following steps:

1. Download and install the [Code Upload Server app](https://github.com/kallistisoft/PocuterUtils/releases) on your Pocuter if you have not done so already.
2. Connect the Pocuter to the same WiFi network as your computer.
3. Start the Code Upload Server app and allow it to connect.
4. Enter the IP address shown in the **IP** fields in the Pocuter App Compiler.

The app will automatically be transferred to the device and run upon successful compilation.

## Building

Open `Pocuter App Compiler.sln` in Visual Studio 2022 or newer and Build the solution.
