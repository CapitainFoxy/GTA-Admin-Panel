@echo off
REM Script to set up the GTA Server Admin database

REM Set database server details
set SERVER_NAME=localhost
set DATABASE_NAME=GTAServerAdmin
set USERNAME=admin
set PASSWORD=admin

REM Run SQL scripts to create and set up the database
echo Creating database...
sqlcmd -S %SERVER_NAME% -U %USERNAME% -P %PASSWORD% -i database/create_database.sql

echo Updating database schema...
sqlcmd -S %SERVER_NAME% -U %USERNAME% -P %PASSWORD% -i database/update_database.sql

echo Seeding initial data...
sqlcmd -S %SERVER_NAME% -U %USERNAME% -P %PASSWORD% -i database/seed_data.sql

echo Database setup complete!
pause
