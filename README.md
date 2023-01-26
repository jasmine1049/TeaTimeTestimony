
## How to Download the Unity Project Using GitHub Desktop

1. Install [GitHub Desktop](https://desktop.github.com/).
2. Sign in with [GitHub.com](https://github.com/). Create an account if you do not have one already.
3. Configure Git with your real name and email.
    - You can use the default option if the information is correct.
    - *Note:* This information will be attached to every change you make.
4. At the top of the screen/window, click 'File' -> 'Clone repository...'
5. Select the URL tab and enter [https://github.com/DrQuackeroo/MagicalGirlGame](https://github.com/DrQuackeroo/MagicalGirlGame) for the repository URL.
    - *Note:* When using GitHub, the link that takes you the GitHub page for the project is also the same link used for cloning.
6. For the local path, select a folder you want the project to be stored in.
    - The default one is OK, and it mostly doesn't matter where you want to store it.
    - Remember where this location is as you will need to tell Unity where this folder is.
7. Click 'Clone'.
    - This will download the latest version of the project, and the .git folder which stores all the history of changes and various information related to the project.
    - At this point, you have a complete backup of the history on your computer that you can modify and view without having to be online.
8. Verify you can see the change history using the 'History' tab underneath the current repository button.

## How to Open the Project in Unity

1. Open the Unity Hub or open Unity directly using your preferred method.
2. Find and select the option to 'Open an existing project'.
3. Select the location of the MagicalGirlGame folder that was cloned from GitHub Desktop earlier.
    - *Hint:* if you didn't change the location, it might be in Documents/GitHub.
    - The MagicalGirlGame folder should contain subfolders titled Assets, Packages, ProjectSettings and other stuff.
4. Wait a minute or two while Unity sets up the project for the first time.
    - *Note:* Git is set up to not store or sync things like add-ons, Unity Store features, or user settings. This is so that everyone can work in the environment they want. With normal use, Git will not delete or modify any such personal settings you use with Unity.
5. If the editor opens without error, congratulations! Please read and understand the next steps before you make changes to the Unity project.

## How to Make and Upload Commits to GitHub

0. Ensure that you have been added as a collaborator and accepted the invitation to collaborate. If you need help with this, see the bottom of this README.
1. **Before you do anything, make sure you have the latest version of the project by opening GitHub Desktop and clicking 'Fetch origin'. Close Unity and reopen the project folder.** 
    - This helps reduce the chances of merge conflicts.
    - *Note:* 'origin' is the name of the GitHub server that stores our project, and 'Fetch' connects to GitHub and downloads the latest commits.
2. Make the changes to the Unity project as you desire. It is best practice to keep the change small and straightforward.
    - For example, instead of changing character movement and background graphics in the same commit, change the character movement first as its own commit and upload it to GitHub. Then repeat the same process for the background graphics.
    - It is OK (and sometimes preferred) if your commit only changes a couple lines of code. We do this so the change history is easy to read and makes sense when reviewing it later.
3. After you made your changes, save your changes and close Unity. Go to GitHub Desktop and click 'Fetch origin' again to make sure you have the latest version. If things changed since you last synced, open Unity again and test that everything works as you changed it.
    - This helps reduce the chances of merge conflicts.
    - *Note:* If you encounter a merge conflict at this step and need help navigating it, look at the bottom of this README.
4. In GitHub Desktop, select the 'Changes' tab underneath the current repository. You should see a list of files that you (or Unity automatically) changed. Normally, you want to commit all the files for the changes you made, so enable the checkboxes for all the files in the list.
    - If you want to save a file change for another commit, uncheck its box and check it later when you are ready.
    - In the case that you want to revert the changes to a specific file, you can right click the file and select 'Discard changes...'. **Be careful as this will permanently delete changes you made.**
5. Type a short sentence (no more than about 10 words) in the Summary box that uses a present-tense verb to describe what your change does. This will show up as the commit's title in the history, so make it clear and concise. 
    - Some examples are 'Add character movement' or 'Tune animation speed on enemy 1b'.
6. Type a description of what your change does in the description box. It can be as detailed as you want, and usually should contain more information on what you changed, how you did it, any ideas for the future, concerns, or other things you want people to read who are curious.
    - *Note:* A description is always optional, but it is a great habit to explain why and how you changed things, for the sake of communication and historical preservation.
7. By default, we will add our changes to the 'main' branch which houses the main, working version of the code. Click the 'Commit to main' button when you are satisfied with the list of files changed, your summary, and description.
8. At this point, your change (in the form of a commit) is saved on your computer's backup of the project. Verify this is true by clicking the 'History' tab underneath the current repository.
    - *Note:* Your commits are not yet uploaded to the GitHub server for everyone else to see.
9. To upload your changes to the GitHub servers, at the top bar, click 'Repostiory' -> 'Push'. The 'Push origin' process should start automatically, which updates the server's copy of the project with the one stored in your computer. 
    - Verify your changes went through by checking the [commit history on GitHub](https://github.com/DrQuackeroo/MagicalGirlGame/commits/main).
    - Congratulations!

## Why You Should Not Panic When Using GitHub

- **Git is made so that you can experiment with massive changes without disrupting the state of the project.**
    - If you want to experiment with massive changes without destroying the working state of the project, Git helps you do this with branching features.
- **If you add or a change a file in a commit, a backup of that file is stored forever.**
    - Even if a new commit deletes a file, that file can almost always be retrieved later if necessary.
- **If you make a bad commit or bad set of changes, it is reversible in nearly every case.**
    - Thanks to the commit history, we have the tools we need to fix problems. All you need to fix mistakes is a bit of expertise and Google.
- **If GitHub somehow goes down or disappears, any computer containing the project has all the information needed to completely restore the project.**
    - Remember when you pressed that 'Clone' button? Git doesn't just download the latest pieces of code onto your computer, but also the entire history of the project from the very beginning.
    - This can be used to upload the project elsewhere if needed.
- **Everyone can see what everyone is doing, and the codebase belongs to everyone.**
    - Git was originally made for people who collaborate with complete strangers on the Internet. By the nature of how Git works, it is very difficult for a bad actor to completely sabotage the codebase. There is an interesting story of a guy who owned an important GitHub codebase and introduced a virus into it. Of course, he was caught doing it almost instantly and virus-free versions of his code were set up immediately, thanks to Git. This shouldn't apply to us, but it is yet another reason why Git and other version control systems are awesome.

## Things to Avoid

- Avoid any option that mentions **rebasing**. It is an advanced Git feature that can mess up other computer's settings if done improperly.

## Resources and Help

- Ping Sammy / DrQuackeroo on Discord for help (the author of this guide).
- [Official Help from GitHub](https://docs.github.com/en/get-started/quickstart/create-a-repo)
    - I recommend creating your own private repository to play around with.
- [Additional reading for using GitHub Desktop](https://docs.github.com/en/desktop)
- [Pro Git, A Free Online Book](https://git-scm.com/book/en/v2)
    - I read this book to learn how to use Git.
    - Great for learning how to use Git on the command line.
- [Documentation for Git on the Command Line](https://git-scm.com/docs)
