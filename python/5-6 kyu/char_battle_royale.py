"""
Substitute two equal letters by the next letter of the alphabet (two letters convert to one):

"aa" => "b", "bb" => "c", .. "zz" => "a".

The equal letters do not have to be adjacent.
Repeat this operation until there are no possible substitutions left.
Return a string.

Example:
let str = "zzzab"
    str = "azab"
    str = "bzb"
    str = "cz"
return "cz"

Notes
The order of letters in the result is not important.
The letters "zz" transform into "a".
There will only be lowercase letters.
"""
def last_survivors(string):
    key = list("abcdefghijklmnopqrstuvwxyz")
    survivor = list(string)

    flag = True
    while flag:
        ret_list = []
        for letter in survivor:
            if letter not in ret_list:
                ret_list.append(letter)
            else:
                winner = key[(key.index(letter) + 1) % 26]
                ret_list.remove(letter)
                ret_list.append(winner)
                
        flag = False
        for i in range(0, len(ret_list)):
            for j in range(0, len(ret_list)):
                if ret_list[i] == ret_list[j] and i != j:
                    flag = True
                    survivor = ret_list
    
    return "".join(ret_list)
