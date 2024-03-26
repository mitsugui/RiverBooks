# ModularMonoliths

Para criar um banco de dados para o sistema utilize o comando:
docker run -e "ACCEPT_EULA=Y" -e "MSSQL_SA_PASSWORD=Riv3rB0oks" -e "MSSQL_PID=Evaluation" -p 11433:1433 --name RiverBooksDatabase --hostname RiverBooksDatabase -d mcr.microsoft.com/mssql/server:2022-preview-ubuntu-22.04