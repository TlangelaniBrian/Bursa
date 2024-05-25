# MSSQL in Docker

Usage:

```
cd $DIRECTORY_CONTAINING_THIS_README
docker-compose up -d
```

You should have mssql with user: `sa` and password `DhvhpBb25`

## Dba Monolith

> It is a hungry beast!


To run its db-changescripts you need to comment out the following lines in `sql.sql` before building the image:

```
sp_configure 'max server memory', 1024;  
GO  
```

