### Author: Justin Mourfield
### Date : April, 20, 2018
### Title: Chapter 01

1.SaaS or software as a service is centrally hosted and managed for the customer. PaaS or Platform as a service is where you deploy your application into an application-hosting environment provided by a cloud service vendor. IaaS or Infrastructure as a Service is a vendor who runs and manages server farms running virtualization software enabling a customer to create virtual machines that run on the vendors infrastructure.

2.The Azure Service Management model splits the various overarching functions that Azure offers into Compute, Data, Application, and network services. the Resource Manager model is the new methodology for deploying resources.  

3.Control planes are used to control services not just deploy them. data planes manage the data used by a service. 

4.Role based access control allows you to set restrictions on who can perform control-plant action. 

5.If the predefined templates for roles doesnt fit exactly to your needs then a new template for a role can be scripted and implemented. 

6. The azure portal dashboard is your desktop. The hub is the like the start menu but for azure resources. Blades are tabs that manage different pages.  

7.When you reach your spending limit, your Azure account will be suspended until the balance is paid.

8.using System;

using System.Diagnostics;

using System.Threading.Tasks;

using System.Collections.Generic;

using System.Linq;

using System.IO;

using System.Runtime.InteropServices;

using Microsoft.Extensions.Configuration;



// Azure Management dependencies

using Microsoft.Rest.Azure.Authentication;

using Microsoft.Azure.Management.Billing;

using Microsoft.Azure.Management.Billing.Models;



namespace billing_dotnet_invoice_api

{

    class Program

    {

        public static IConfigurationRoot Configuration { get; set; }

        private static void Write(string format, params object[] items) 

        {

            Console.WriteLine(String.Format(format, items));

        }

        public static void Main(string[] args)

        {

            Run().Wait();

        }

        public static async Task Run()

        {

            BillingClient billingClient = await GetBillingClient();

            

            // Call the invoices service and expand the downloadURL, this call may take a while'

            // TODO: handle 404 invoice not found

            Write("Calling invoice service for all available invoices...");

            List<Invoice> allInvoices = billingClient.Invoices.List("downloadUrl").ToList();



            Write("{0} invoice(s) received.  Press ENTER to see them.", allInvoices.Count);

            Console.ReadLine();

            

            allInvoices.ForEach(inv => {

                Write("\tName: {0}", inv.Name);

                Write("\tDate: {0} to {1}", inv.InvoicePeriodStartDate, inv.InvoicePeriodEndDate);

                Write("\tPress ENTER to open PDF in browser");

                Console.ReadLine();

                OpenURL(inv.DownloadUrl.Url);

            });

            Write(Environment.NewLine);

        }

        public static async Task<BillingClient> GetBillingClient()

        {

            // Import config values from appsettings.json into billingClient, or throw an error if not found

            var builder = new ConfigurationBuilder()

                .SetBasePath(Directory.GetCurrentDirectory())

                .AddJsonFile("appsettings.json");



            Configuration = builder.Build();



            var tenantId = Configuration["TenantDomain"];

            var clientId = Configuration["ClientID"];

            var secret = Configuration["ClientSecret"];

            var subscriptionId = Configuration["SubscriptionID"];



            if(new List<string>{ tenantId, clientId, secret, subscriptionId }.Any(i => String.IsNullOrEmpty(i))) {

                throw new InvalidOperationException("Enter TenantDomain, ClientID, ClientSecret and SubscriptionId in appsettings.json");

            }

            else

            {

                // Build the service credentials and ARM client to call the billing API

                var serviceCreds = await ApplicationTokenProvider.LoginSilentAsync(tenantId, clientId, secret);

                var billingClient = new BillingClient(serviceCreds);

                billingClient.SubscriptionId = subscriptionId;

                return billingClient;

            }

        }

        public static void OpenURL(string url)

        {

            try

            {

                Process.Start(url);

            }

            catch

            {

                // https://github.com/dotnet/corefx/issues/10361

                if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))

                {

                    url = url.Replace("&", "^&");

                    Process.Start(new ProcessStartInfo("cmd", $"/c start {url}") { CreateNoWindow = true });

                }

                else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))

                {

                    Process.Start("xdg-open", url);

                }

                else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))

                {

                    Process.Start("open", url);

                }

                else

                {

                    throw;

                }

            }

        }        

    }

}
9. JSON files