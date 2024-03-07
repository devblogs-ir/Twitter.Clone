# User Address

Finding a user's address information can be one of your challenges in web applications. 
Actually, you need to get the IP address of the user then access the address information based on it.

![image](https://github.com/devblogs-ir/Twitter.Clone/assets/3371886/f431bbda-c296-4c18-b129-7edb1506af93)

# Accessing to the Address
There are various solutions for this task, but the simplest one is to use GeoLocation providers, which provide you with the possibility to access the user's address easily and only by using the user's IP address.

`Remember, the user's IP comes with the HTTP request.`

![image](https://github.com/devblogs-ir/Twitter.Clone/assets/3371886/097e4482-8711-4fa4-8e37-48f006fd4dbb)

# Locator on your Microservice

If your application architecture is based on microservices, it is better to develop a separate service to use this provider. This allows you to reuse and maintain and develop it separately.

![image](https://github.com/devblogs-ir/Twitter.Clone/assets/3371886/14e1bf40-0432-4400-8642-7a1b2995498b)

# The locator works like a proxy
Duplicate requests are always there, in order not to send a duplicate request to the Geolocation provider every time, it is better to cache your requests.
![image](https://github.com/devblogs-ir/Twitter.Clone/assets/3371886/54c9fb99-2f96-48f4-9e18-0ffaa9d2805a)
