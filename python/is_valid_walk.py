"""
You live in the city of Cartesia where all roads are laid out in a perfect grid. You arrived ten minutes too early to an appointment, so you decided to take the opportunity to go for a short walk. The city provides its citizens with a Walk Generating App on their phones -- everytime you press the button it sends you an array of one-letter strings representing directions to walk (eg. ['n', 's', 'w', 'e']). You always walk only a single block for each letter (direction) and you know it takes you one minute to traverse one city block, so create a function that will return true if the walk the app gives you will take you exactly ten minutes (you don't want to be early or late!) and will, of course, return you to your starting point. Return false otherwise.

Note: you will always receive a valid array containing a random assortment of direction letters ('n', 's', 'e', or 'w' only). It will never give you an empty array (that's not a walk, that's standing still!).

#some test cases for you...
test.expect(is_valid_walk(['n','s','n','s','n','s','n','s','n','s']), 'should return True');
test.expect(not is_valid_walk(['w','e','w','e','w','e','w','e','w','e','w','e']), 'should return False');
test.expect(not is_valid_walk(['w']), 'should return False');
test.expect(not is_valid_walk(['n','n','n','s','n','s','n','s','n','s']), 'should return False');
"""

def is_valid_walk(walk):
    #determine if walk is valid
    if len(walk) == 10:
        origin = [0,0]
        for direction in walk:
            if direction == 'e':
                origin[0] += 1
            elif direction == 'w':
                origin[0] -= 1
            elif direction == 'n':
                origin[1] += 1
            elif direction == 's':
                origin[1] -= 1
                
        if origin[0] == 0 and origin[1] == 0:
            return True
        else:
            return False
    else:
        return False
