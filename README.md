# Artefacts manager
The system consists of a module that allows you to manage artifacts from RPC games as well as a module that allows you to manage users (assigning roles defined by permissions)
## Setup
To run this project, you need to have database locally. Steps:
1. Change connection_string in file <code>App.config</code>
2. Create migration: <code>PM>add-migration createDb</code>
3. Create database: <code>PM>update-database</code>
4. Run SQL script to get basics data to your database. MySQL script is in the Script folder.
### Users after execute script
| username | password |
|----------|----------|
| creator  | creator  |
| editor   | editor   |
| admin    | admin    |

## Overview
![image](https://user-images.githubusercontent.com/72666064/188490795-7d62b0a4-a4d9-4018-b235-5ed455085ddd.png)
![image](https://user-images.githubusercontent.com/72666064/188491721-d54584aa-637b-4c46-83cc-ad3ec7b87220.png)
![image](https://user-images.githubusercontent.com/72666064/188490858-d6f6953d-0cd2-441e-9fdc-e8b8b6380b35.png)
![image](https://user-images.githubusercontent.com/72666064/188491063-be687817-a170-4075-9ff0-e5408393af5b.png)
![image](https://user-images.githubusercontent.com/72666064/188491047-0e95e7ad-41cc-4c1b-889c-de895e19a9e2.png)



