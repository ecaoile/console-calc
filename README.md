# console-calc - Calculator app for 401 prework (the right way)

## 1. How to install and run
- The following must be installed
	- .NET Core SDK
	- Visual Studio
- Download the files from GitHub using the clone URL provided on the repo page.
- The program can be accessed directly by opening the console-calc.exe file found in the main directory.
- To access the code, do the following:
	- Open Visual Studio and open the ConsoleCalc.sln file found in the first ConsoleCalc folder.
	- Hit the green play button with ConsoleCalc next to it to run the program.

## 2. Process and issues while doing this assignment:
It took about 4 hours to finish this assignment. The logic was fairly intuitive for most of the program.
I struggled at the end with figuring out how to delete the first equation and insert a new equation after
the first 5 initial inputs. It turns out that I had to use a string list in order to be able to work with an array
that can change in size since arrays themselves can't do so.

## 3. Resources used for this assignment:
Prework tutorials:
https://github.com/codefellows/code-401-dotnet-prework/blob/master/prework-tutorials.md

How to initialize a string list:
https://stackoverflow.com/questions/3139118/how-to-initialize-a-c-sharp-string-list-liststring-with-many-string-values

Adding an element to a list:
https://msdn.microsoft.com/en-us/library/3wcytfd1(v=vs.110).aspx

Catching Exception:
https://stackoverflow.com/questions/12550184/throw-a-format-exception-c-sharp