def reverseWords_manual(s: str) -> str:
   res = ''
   l, r = 0, 0
   while r < len(s):
      if s[r] != ' ':
        res += 1
      else:
        res += s[l:r+1][::-1] # r + 1 pois em python o slicing o final e exclusivo
        r += 1
        l = r 

   res += ' '
   res += s[l:r+2][::-1]  # Adiciona a última palavra e mais 2 pois o while saiu no penultimo espaço
   return res[1:]   
     
