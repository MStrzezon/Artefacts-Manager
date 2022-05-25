# Artefacts manager
## Setup
To run this project, you need to have database locally. Steps:
1. Change connection_string in file <code>App.config</code>
2. Create migration: <code>PM>add-migration createDb</code>
3. Create database: <code>PM>update-database</code>
4. Run SQL script to get basics data to your database. MySQL script is in the Script folder.
