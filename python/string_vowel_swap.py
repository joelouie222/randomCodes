"""
Question from: https://www.youtube.com/watch?v=kOSiLiQFa5Y

Given a string, swap the position of all the vowels
left outer most vowel will swap with right outer most vowel
keep moving inward until all vowels are swap
in case there are odd number of vowels, the middle vowel will be unchanged

Example:
Input: "apples and oranges"
Output: "epplas ond arengas"

Input: "journal"
Output: "jaurnol"
"""
def vowel_swap(var):
    temp_var = var.lower()
    vowels = ""

    for letter in temp_var:
        if letter in "aeiou":
            vowels += letter

    vowels = list(vowels)
    for i in range(0, len(vowels) // 2):
        temp = vowels[i]
        vowels[i] = vowels[len(vowels) - i - 1]
        vowels[len(vowels) - i - 1] = temp

    var = list(var)
    i = 0
    for j, letter in enumerate(var):
        if letter.lower() in "aeiou":
            if letter.isupper():
                var[j] = vowels[i].upper()
            else:
                var[j] = vowels[i]
            i += 1

    return "".join(var)


print(vowel_swap("apples and oranges"))
print()
print(vowel_swap("journal"))
print()
print(vowel_swap("GOOGLE INTERVIEW QUESTION SOLVED: REVERSE VOWELS IN A STRING"))
