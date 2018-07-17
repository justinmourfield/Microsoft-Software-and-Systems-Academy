### Author: Justin Mourfield
### Date : May, 27, 2018
### Title: Chapter 03

1.A virutal machine is software loaded on or into a computer that can mimic a computer with different software or hardware.

2. Stop-AzureVM you can execute this through a powershell cmdlet or through the azure CLI

3. The network resource provider is Microsoft.Network, storage resource is provided by Microsoft.Storage and the compute resource is provided by Microsoft.Compute. 

4.Both the OS disk and data Disk are backed by page blobs in Azure storage. Since they are stored within the Azure storage they inherit benefits of blob storage such as high availability, durability, and geo-redundancy options. The azure platform holds an infinite lease with the page blobs to  prevent accidental deletion of the page blob containing the VHD, the related container, or the storage account. 

5.A VM must be assigned a IP address via an associated NIC. 

6. A NIC provides network access to resources in an Azure virtual network. Each NIC has an associated private address used to connect to the virtual network and is optionally associated with a public IP address conected directly to the public internet.  

7.To avoid a single point of failure in the event of an external issue or delay in Azure resources being used (server failure or update) it is recommended to have at least two instances of the VM. 

8. You can connect to a virtual machine either remotely or by configuring network access to allow other programs or services to communicate with the VM.

9.Largely the management of a VM is on the user. 

10. It is important to determine the maximum number of VMs because that maximum number of Vm must be created configured and placed into the availability set. 