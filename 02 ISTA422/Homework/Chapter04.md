### Author: Justin Mourfield
### Date : May, 27, 2018
### Title: Chapter 04

1. A blob is an acronym for Binary large object. Blobs are basically files like that of which you store on your computer. the Azure blob service gives you the ability to store files and access them from anywhere in the world using URLs, the REST interface, or one of the Azure SDK storage client libraries. 

2. To use Azure storage you have to create a storage account. once you have an account you can create containers which are similar to folders, and then put blobs in the container.

3. Many on-premises applications use file shares, configuration files can be stroed on a file share and accessed by multiple VMs, Diagnostic logs metrics, crash dumps etc can be saved to a file share to be processed and analyzed later, tools and utilities used by multiple developers in a group can be stroed on a file share to ensure that everyone uses the same version and that they are available to everone within the group. 

4. Local redundant storage provides high availability by ensuring that three copies of all data are made syncronously before a write is deemed successful. these copies are stored in a single facility in a single region. 

5. The Azure Key vault helps safeguard cryptographic keys and secrets used by the Azure applications and services. 

6. Disk encryption enables you to specify that the OS and data disks used by an IaaS VM should be encrypted. 

7. CLient side encryption is when data is encrypted by the application and sent across the wire to be stored in the storage account. when retrieved, the data is decrypted by the application.

8.-Upload blobs from the local folder on a machine to Azure Blob storage.
-Upload files from the local folder on a machine to Azure File storage.
-Copy blobs from one container to another in the same storage account.
-Copy blobs from one storage account to another, either in the same region or in a different region.
-Copy files from one file share to another in the same storage account.
-Copy files from one storage account to another, either in the same region or in a different region.
-Copy blobs from one storage account to an Azure File share in the same storage account or in a different storage account.
-Copy files from an Azure File share to a blob container in the same storage account or in a different storage account.
-Export a table to an output file in JSON or CSV format. You can export this to blob storage.
-Import the previously exported table data from a JSON file into a new table. (Note: It won’t import from a CSV file.)

9. Access keys, Configuration, Custom domain, encryption, diagnostics, and users are all located within the settings blade. 

10. I learned there are four different types of storage offered through azure and that each one has specific use cases and that the security of the information they contain can be altered at the server or client level.