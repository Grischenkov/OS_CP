﻿import datetime
import sys
import os

dirname     = os.path.dirname(__file__)
filename    = os.path.join(dirname, 'OS_CP\Views\AboutView.Designer.cs')
sub         = "this.Version.Text = "
curdate     = datetime.datetime.today()
date        = curdate.strftime("%d/%m/%Y")

if __name__ == "__main__":
    if len(sys.argv) > 1:
        file = open(filename, "r")
        lines = file.readlines()
        file.close()

        i = 0
        for text in lines:
            if sub in text:
                break;
            i = i + 1
        lines[i] = "            this.Version.Text = " + '"' + "Version: " + sys.argv[1] + '    ' + date + '"' + ";" + '\n'  
        
        file = open(filename, "w")
        file.writelines(lines)

        print("Version number bumped to " + sys.argv[1])
    else:
        print("Relaunch script and type version number. ($python bump-version.py 0.0)")