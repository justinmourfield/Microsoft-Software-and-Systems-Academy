### Author: Justin Mourfield
### Date : June 19, 2018
### Title: Chapter 05

1. VNets or virtual networks are used to provide private connectivity for Azure Virtual Machines (Azure VMs) and some Azure services. VMs and services that are part of the same VNet can access one another.

2. A Virtual Network Gateway is a fully managed service in Azure that is used for cross-premises connectivity. 

3. The three things you need to know when creating a virtual network is the address space, subnets, and the DNS servers you want to use. 

4.Subnets are created to break up your virtual network into more manageable sections. 

5. When establishing a virtual network, VMs are assigned their IP address during deployment or startup so the network must be established prior to the VMs being created.

6. You set the location of the Resource group to establish which Azure region that will be used for the resources when they are created.

7. The rules to editing Resource group templates are:
-if you remove a resource from the template that is not in the resource group, that resource will be unchanged. It wont be removed simply because its gone from the template. 
-if you add a resource to the template that is not in the resource group, it will create that resoure for you when you redeploy the template
-resources that are unchanged but are still in the template will be ignored
-resources that are changed and still in the template will be updated.

8.You should avoid a complete deplyment using powershell because it will delete resources that are in the resource group but not in the template when you redeploy.

9. Microsoft created Network Security Groups (NSG) to provide flexible methods for defining the access rules allowing traffic into and out of a VM in a VNet or even an entire subnet in the VNet.

10. A VPN Gateway is an Azure managed service that is deployed into a VNet and provides the endpoint for VPN connectivity for point-to-site VPNs, site-to-site VPNs, and ExpressRoute. This gateway is the connection point into Azure from either the on-premises network (site-to-site) or the  client machine (point-to-site).