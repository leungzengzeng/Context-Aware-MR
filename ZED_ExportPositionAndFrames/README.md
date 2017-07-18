# Stereolabs ZED Export Position and Frames by Karl :D
## Build the program

#### Build for Windows

- Create a "build" folder in the source folder
- Open cmake-gui and select the source and build folders
- Generate the Visual Studio `Win64` solution
- Open the resulting solution and change configuration to `Release`
- Build solution

#### Build for Linux

Open a terminal in the sample directory and execute the following command:

    mkdir build
    cd build
    cmake ..
    make


## Run the program

- Navigate to the build directory and launch the executable file
- Or open a terminal in the build directory and run the sample
- It will automatically start recording


*NOTE:* Camera tracking is based on 3D vision only. Quick and sudden camera movements can be difficult to track if the image is blurry or there is no visual information in the scene. To improve tracking performance, we recommend using the ZED in HD720 mode at 60fps.