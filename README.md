# Git Shell Cheat Sheet

- In the Command prompt, add the URL for the remote repository where your local repository will be pushed.

$ git remote add origin [remote repository URL]

$ git remote -v

- Remove several deleted files at once
 
$ git rm $(git ls-files --deleted)
