using ExpenseViewer.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//DI
builder.Services.AddDbContext<ApplicationDbContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("DevConnection")));

Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MjI1MzMxM0AzMjMxMmUzMDJlMzBnQWFpQUxCK3BCYXJINXM1dk9Kdkh5ZjlJTldmOGdOa1VsNGFUdUxXMERNPQ==;Mgo+DSMBaFt+QHJqVk1mQ1dbdF9AXnNNdFNwT2ZZbz4Nf1dGYl9RQXVfQ1tjT3tTcUJlWA==;Mgo+DSMBMAY9C3t2VFhiQlJPcEBEQmFJfFBmQWlZeVR1dEUmHVdTRHRcQlhgSX9VdkNmWXhXeXU=;Mgo+DSMBPh8sVXJ1S0R+X1pCaVldX2NLfUNyT2NfdVtwZDU7a15RRnVfR15jSHhTcEBjUX5bcQ==;MjI1MzMxN0AzMjMxMmUzMDJlMzBUOTg2TEVwYUVTTkJmWXNIWDhCY0g2c3M5Y25hMDNjcHhQcFIyMWIwUFZnPQ==;NRAiBiAaIQQuGjN/V0d+Xk9HfVldW3xLflF1VWdTf1h6cVVWACFaRnZdQV1mSn5ScEVlXH9Wd3ZU;ORg4AjUWIQA/Gnt2VFhiQlJPcEBEQmFJfFBmQWlZeVR1dEUmHVdTRHRcQlhgSX9VdkNmWXdXcHU=;MjI1MzMyMEAzMjMxMmUzMDJlMzBqM1h1Y2lEN2hPQ0Z2NFh1ckNlQnZEeUhrRVo0bHF6QWtyWjhrNEJsWjUwPQ==;MjI1MzMyMUAzMjMxMmUzMDJlMzBXck8vcFg4ZjNVRFRwTThFRzJYbkIxeFU3NGFxRVF3U2h6cW4rNnVwNFhvPQ==;MjI1MzMyMkAzMjMxMmUzMDJlMzBjbVRraVBkVFlKUzBSbzNXSWFKbi9pSHZ6aHFHQzdhRFJCbmhvd2J0eVFFPQ==;MjI1MzMyM0AzMjMxMmUzMDJlMzBCK2NXaDVSd1Z2Z0NhcGUrNDM2ZkJUZ0VXZWNHQXRqSU5xaE1pcmZNS1lVPQ==;MjI1MzMyNEAzMjMxMmUzMDJlMzBnQWFpQUxCK3BCYXJINXM1dk9Kdkh5ZjlJTldmOGdOa1VsNGFUdUxXMERNPQ==");

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Dashboard}/{action=Index}/{id?}");

app.Run();
