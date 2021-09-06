math_opers = ['+', '-', '*', '/', '^', '(', ')']

def rpn(expr):
  expr = parse(expr)
  main = []
  opers = []
  for token in expr:
    if token not in math_opers:
      main += [token]
      continue
    if len(opers) == 0 or token == '(':
      opers = [token] + opers
      continue
    if token == ')':
      while True:
        poped = opers[0]
        opers = opers[1:]
        if poped == '(':
          break
        main += [poped]
      continue
    if prty(opers[0]) < prty(token) or \
     token == '^' and opers[0] == '^':
      opers = [token] + opers
      continue
    while True:
      if len(opers) == 0: break
      poped = opers[0]
      opers = opers[1:]
      main += [poped]
      if prty(poped) == prty(token):
        break
    opers = [token] + opers
  while len(opers) != 0:
    poped = opers[0]
    opers = opers[1:]
    main += [poped]
  return main

def prty(c):
  if c in '+-': return 1
  if c in '*/': return 2
  if c in '^': return 3
  return 0

def parse(expr):
  main = []
  num = ""
  for c in expr:
    if c == ' ':
      continue
    if c not in math_opers or \
     c == '-' and len(num) == 0:
      num += c
      continue
    if len(num) != 0:
      main += [num]
      num = ""
    main += [c]
  if len(num) != 0:
    main += [num]
  return main

s = "(99 + 23) - (123 + 69) - (12 + 55)"
print '|'.join(parse(s))
print
print '|'.join(rpn(s))
