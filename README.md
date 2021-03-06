# GDPRDataCatalog
Example on how to use Azure Data Catalog, Data Factory, Data Lake, Functions and Power BI for GDPR

## Requirements:
- A Data catalog with a service principal that can read data
- A Data Lake Store with same service principal to write data
- A Data Lake Analytics account
- A Data Factory (v2) to do orchestration

## Contents:
### PowerShell scripts (to be run inside azure function with HTTP trigger)
- /Solution/PowerShell/ExportBusinessGlossary.ps - PowerShell script to export business glossary
- /Solution/PowerShell/SearchDataCatalog.ps - PowerShell script to search data catalog for a given business glossary term
- /Solution/PowerShell/AddColumnGlossaryTag.txt - PowerShell script to add business glossary tags to a column


## U-SQL scripts
- /Solution/USQL-PBI Input/ReadBusinessGlossary.usql - reads and transforms business glossary export (could be presented in Power BI)
- /Solution/USQL-PBI Input/ReadDataCatalog.usql - reads and transform Data Catalog export (could be presented in Power BI)
- /Solution/USQL/CreateColumnAndTagList.usql - creates list of tagged and not tagged columns, to be tagged in Excel 
- /Solution/USQL/ReadColumnAndTagList.usql - reads output from above, and filled excel (saved as csv) to create input to AddColumnGlossaryTag 
Function


## Data Factory pipelines:
- /Solution/ADF v2 pipelines/ExportDataCatalog.json - exports data catalog and glossary, and runs U-sql
- /Solution/ADF v2 pipelines/AddGlossaryTags.json - reads a blob with data from ReadColumnAndTagList.usql and calls Azure Function

## Disclaimer:
All code is used at own risk. We would like recommendations to improvements, and thanks if this is helpful. This code is shared from Hafslund Strøm (part of Fortum) as we would like everybody to handle GDPR and personal data well. 
