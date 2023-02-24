# ISS-Virtual-Reality-Simulation
Shared class project for cpsc 4110

## Steps for Cloning, Pulling, Staging, Commiting, and Pushing our files

### First Time Setup
Open the git CLI and navigate to where you want the Unity project to live
Run the following commands
- git clone https://github.com/Vetas-Luna/ISS-Virtual-Reality-Simulation.git [Directory you want the files to go into]*Note*(will create one if name doesnt exist already)
- cd [Directory made above]
- git status (confirm that the files are there)
- git remote add origin git@github.com:Vetas-Luna/ISS-Virtual-Reality-Simulation.git
- git add .
- git commit -m "First commit, (Your Name)"
- git push --set-upstream origin main


### Main Work Loop

#### Everytime you sit down to work on the project
run the command
- git pull

Then create a new branch (or switch to an existing, UP-TO-DATE branch)
When creating a new branch, the name can typically be your name, however if you want to mess around with a couple of different changes at the same time, (for example, while trying to decide what method you'd like to use to implement a particular change, or comparing multiple different UIs or something), it can be the name of the feature. Just make sure it's distinct.
To create and switch to a new branch, run the command
- git checkout -b branchName

To switch to an existing branch, run the command
- git checkout branchName

next open up unity and click OPEN, Navigate to your projects directory and again click OPEN

#### After your done how do you commit the files?
Run the folowing commands
It's best to commit your changes often!
- git add .
- git commit -a -m "(Brief msg of what you did)"


### How do you work with git branches?
Whenever you're ready to push changes to the remote repo, you'll want to push the changes into a new remote branch. 
The following command will create a remote branch named branchName (unless it already exists) and push your changes to it
- git push origin branchName

Next, travel to GitHub online. There, you'll see recent changes on a branch with whatever name you assigned to it. Now, click the pull requests tab and create a new pull request with the changes that you've made. Once you've created the pull request, it will automatically check to see if it can merge into the main branch as is. Other people can check over the code while it's a pull request, so if you want an extra set of eyes, ask a teammate. If it can automatically merge, it's ok to click merge and let it do its thing. If it says that it can't automatically merge, it'll allow you to view the merge conflicts and choose which version of each change (the one on the main branch or the one you just submitted) you want to exist on the main branch. This can be a lot easier than trying to do it locally! Once the merge has completed, you can delete the remote branch.
Back on your local computer, you'll want to travel back to the main branch (git checkout main) and make a pull (git pull). This will update your local main version. Afterwards, either
1) Delete the branch you were working on (git branch --delete branchName) OR
2) Travel back to the branch you were working on (git checkout branchName) and try to pull from the main branch (git pull origin main).

If I just submitted a pull request and am updating my local main with a pull, I usually will just do option 1 and create a new branch to work on (either with the same name or a new name).

However, if someone has made significant changes to the remote main branch while I've been working on my branch, sometimes it's necessary to do option 2 so that you can update the code that you're working on. This is especially helpful if you've been working in the same files. It's important to know that sometimes this will cause a merge conflict, which is sometimes very easily fixed and other times not, so I suggest doing option 1 unless you need to.

After you've either created a new branch or updated your old one with a pull, you're good to move to the new branch and make new changes from there.


### Why use git branches?
The reason behind using git branches is mainly to catch and prevent merge conflicts, keep the main branch intact, and to make it easier to deal with merge conflicts when they do happen. Basically, the rule is if you're working on something new locally, do it on a branch and push it to a new remote branch. I tend to stay on a branch at all times, so I'm only ever on main when I'm trying to update my local version. Here's a list of helpful commands when working with branches:
- git checkout -b branchName (create a new branch and move to it)
- git checkout branchName (move to an existing branch)
- git branch (lists what branches you have and tells you which one you're on)
- git push origin branchName (creates a new remote branch and pushes to it)
- git branch --delete branchName (delete a branch)



# FIN