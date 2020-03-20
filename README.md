# Encode-Decode-num-Util
Util to Convert from numeric to Unique String and vice versa
## Overview ##

 - this helper util helps to encode numbers to strings and decode aswell
 - you can set the desired minimum length 
 
## Use Case : ##
 when you need to generate a code based on a number (like a giftcode) and you want to be able to decode it to number again.  
 
 ## Example : ##
 
Examples of length 4 :
```shell
0 is encoded to 2VPV and decode result is 0  
1 is encoded to 3VPV and decode result is 1  
2 is encoded to 4VPV and decode result is 2  
3 is encoded to 5VPV and decode result is 3  
4 is encoded to 6VPV and decode result is 4  
5 is encoded to 7VPV and decode result is 5  
6 is encoded to 8VPV and decode result is 6  
7 is encoded to 9VPV and decode result is 7  
8 is encoded to AWPV and decode result is 8  
9 is encoded to BWPV and decode result is 9  
10 is encoded to CWPV and decode result is 10  
11 is encoded to DWPV and decode result is 11  
12 is encoded to EWPV and decode result is 12  
13 is encoded to FWPV and decode result is 13  
14 is encoded to GWPV and decode result is 14  
15 is encoded to HWPV and decode result is 15  
16 is encoded to IWPV and decode result is 16  
17 is encoded to JWPV and decode result is 17  
18 is encoded to KWPV and decode result is 18  
19 is encoded to LWPV and decode result is 19  
```
_Note: you can use a salt to change the shape of adjacent strings (not included)_
