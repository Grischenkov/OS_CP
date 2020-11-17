# Operating Systems, Course project. #
## Basic information ##
This program is designed to track the parameters of the technological process and build a graph of these parameters.
The program provides the ability to connect libraries of data export and libraries of mathematical data processing. 
It also allows you to save a table of values of technological process parameters and an image of the resulting graph.
Libraries are connected to the project dynamically.
Application settings are saved in the registry.

## Settings capabilities ##
- Enable / Disable display of video of the technological process.
- Enable / Disable the loading screen display when the program starts.
- Enable / Disable export libraries.
- Enable / Disable mathematical data processing libraries.

## Loading data ##
Loading data for the program is possible from `*.txt` files.
#### The data in the file must be in the following format: ####
```
value value value
value value value
.....
value value value
```
#### Limitations of the data presentation format: ####
- There must be ONE space between the values in the file.
- After the last value in the line, a space is NOT put.
- All lines, EXCEPT THE LAST, end with a line break.
- The fractional part of value must be separated by a COMMA.
- If a number is represented in an exponential notation, the exponent can be written in both lowercase and uppercase LATIN letters.

## Saving data ##
#### Saving data from the program is possible in two formats: ####
- `*.txt` to save the table of values.
- `*.jpg` to save the chart image.

*The option to save the chart image is available only if it was built in the program.*

## Export ##
The program's data export capabilities depend on the library you are using. 
#### The default installation contains two libraries: ####
- `MSExcelExport.dll`, which supports export of table of values as well as graphics to Microsoft Excel.
- `MSWordExport.dll`, which only supports export of table of values.

*You can specify the path to one of these or third-party libraries in the "Settings" window in the "Export type DLL" item.*

## Math ##
The program's mathematical data processing capabilities depend on the library used.
#### The default installation contains one library: ####
- `Interpolation.dll`, which implements data interpolation.

*You can specify the path to this or third-party libraries in the Preferences window in the Math type DLL program.*

**IMPORTANT:** When using libraries of mathematical data processing, the program will display already processed data.
Also, when saving or exporting data, the processed data will be used.

***

## For Developers ##
### EXPORT DLL API ###

#### For correct collaboration of the application and dll in the library project, you must use the following function formats: ####
- `public string Name => ""` - returns the name of the program to export to.
- `public void Export(double[][] table)` - generates and saves a file.

Also, the library file name must match the namespace, and the class must be named "EXPORT".

### MATH DLL API ###
#### For correct collaboration of the application and dll in the library project, you must use the following function formats: ####
- `public string Name => ""` - returns the name of the mathematical data processing method.
- `public double[][] Process(double[][] table)` - returns the processed value table.
       
Also, the library file name must match the namespace, and the class must be named "MATH".
