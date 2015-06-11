//Problem 7. Parse URL
//
//Write a script that parses an URL address given in the format: [protocol]://[server]/[resource] and extracts from it the [protocol], [server] and [resource] elements.
//Return the elements in a JSON object.
//
//    Example:
//URL 	                                                        result
//http://telerikacademy.com/Courses/Courses/Details/239 	{ protocol: http,
//                                                      server: telerikacademy.com
//                                                      resource: /Courses/Courses/Details/239

var url = 'http://telerikacademy.com/Courses/Courses/Details/239';

function parseURL(url){
    var protocol,
        server,
        resource;
    protocol = url.slice(0, url.indexOf('://'));
    url = url.replace(protocol + '://', '');
    server = url.substring(0, url.indexOf('/'));
    resource = url.substring(url.indexOf('/'));
    return {protocol: protocol, server: server, resource: resource};
}

console.log(parseURL(url));