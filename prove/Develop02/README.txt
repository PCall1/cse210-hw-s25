1. **Program Initialization**: The program starts by displaying a 
menu of options for the user. These menu options will include:

    [1] creating a new journal entry
    [2] viewing current entries
    [3] saving entries to a file
    [4] loading entries from a file
    [5] and exiting when finished

2. **User Interaction**: The user selects an option from the menu. 
For example:

    [1] If the user chooses [1] to create a new entry, the program 
    calls the PromptCeption() method and prompts them with a 
    question, they may also ignore the prompt as they journal.

    [2] If the user chooses to view entries, the program displays 
    all recent and loaded entries.

    [3] If the user chooses to save their entry, the program saves 
    the current entries to a Journal folder and will prompt the 
    user to name the file.

    [4] load entries, the program will ask for a file name, from 
    which it will load that file and then can be displayed with [2]
    
    [5] Exits the program when the user is done and presses [5] 
    from the menu
    

4. **Backstage**: "switch" will be used for each of the choices in 
the menu.

When the user opts [1] to create a new journal entry
the program will show them a prompt and prepare to save their entry
with the date, time, and prompt included in the file. This will involve
the Entry class, and the PromptGenerator class. pressing [enter] will
save the information to memory temporarily. (each class will be defined 
in their own file)

When the user opts to save their journal entry to a file, this will 
involve SaveJournal() in the Journal class and use variables from 
the Entry class. The journal entry will be saved to a Journal folder 
with a file name specified by the user. 

If the user wants to load a file from storage, the user will specify 
what file they want to load, and the program will use LoadJournal()
to load it into memory where it can be accessed with Display().

If the user wants to view the open journal entries, they can enter [2]
which will display any current entries and entries loaded from storage.

** Each of the images will be used to also visualize the program and 
organize the classes, methods, and member variables.
