"""
Funny Dots
You will get two integers n (width) and m (height) and your task is to draw the following pattern. Each line is seperated with a newline (\n)

Both integers are equal or greater than 1; no need to check for invalid parameters.

Examples
                                            +---+---+---+
             +---+                          | o | o | o |
dot(1, 1) => | o |            dot(3, 2) =>  +---+---+---+            
             +---+                          | o | o | o |
                                            +---+---+---+
"""
def dot(n,m):
    fence = "+"
    herd = "|"
    for i in range(0, n):
        fence += "---+"
        herd += " o |"
    
    ret_list = []
    for j in range(0, m * 2 + 1):
        if j % 2 == 0:
            ret_list.append(fence)
        else:
            ret_list.append(herd)
    
    return "\n".join(ret_list)

#print(dot(1,1))
#print(dot(3,2))
#print(dot(6,9))
#print(dot(10,5))
