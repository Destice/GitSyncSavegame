# GitSyncSavegame
small app with GUI to pull/push game saves to git repo


## How to use

### Configuration
1. Input git repo link, eg. https://github.com/Destice/FarmingSimulator2022
      * repo contains synced game save dir (file structure  - start from where you want your local repo to be)
 
2. Input game save files path (also your local git repo location), eg. C:\Users\User\Documents\My Games\FarmingSimulator2022

3. Input your synced directory/file path (same as in remote repo), eg. savegame3

4. Click "Save paths" - saves your inputs

### Usage
1. First time: click "Clone repo" - removes old file, pulls from remote, sets local git repo up

2. If you see newer save on remote repo - click Pull

3. After you finish playing - click Push

![image](https://user-images.githubusercontent.com/83007545/206921351-c488f73b-6ddd-4f4b-a2b1-2ac6b647bae4.png)
