"""
You will get an odd integer n (>= 3) and your task is to draw an X. Each line is separated with \n.
Use the following characters: ■ □ For Ruby, Crystal and PHP: whitespace and o
Examples
                                     ■□□□■
            ■□■                      □■□■□
  x(3) =>   □■□             x(5) =>  □□■□□
            ■□■                      □■□■□
                                     ■□□□■
"""
def x(n):
    ret_str = []
    for i in range(0, n):
        pattern = list("□" * n)
        pattern[i] = "■"
        pattern[n - 1 - i] = "■"
        ret_str.append("".join(pattern))
    return "\n".join(ret_str)
