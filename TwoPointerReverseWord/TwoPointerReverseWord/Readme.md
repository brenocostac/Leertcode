# Invertendo Palavras em uma Frase

Este projeto inverte a ordem das palavras em uma frase (ex: "Olá Mundo" vira "Mundo Olá"), mantendo as letras de cada palavra intactas.

## Performance: Quão Rápido e Quanta Memória?

Ao analisar a "complexidade", avaliamos o desempenho do algoritmo em relação ao tamanho da entrada.

### Complexidade Temporal: O(N) (Tempo Linear)

O algoritmo é eficiente e executa em tempo "linear", ou $O(N)$, onde $N$ é o número de caracteres na frase. Isso significa que o tempo de execução cresce proporcionalmente ao tamanho da entrada.

**Por quê?**
* O código percorre a string um número fixo de vezes.
* Cada caractere é processado um número constante de vezes.
* Se a frase dobrar de tamanho, o tempo de execução também dobrará aproximadamente.

### Complexidade Espacial: O(N) (Espaço Linear)

A complexidade de espaço também é "linear", ou $O(N)$. Isso indica que a memória extra utilizada cresce proporcionalmente ao tamanho da entrada.

**Por quê?**
* O algoritmo cria um novo array de caracteres (`char[] charArr`) com o mesmo tamanho da string de entrada para realizar as operações.
* Embora algumas operações sejam feitas "no local", a necessidade de uma cópia inicial da string resulta em um consumo de memória proporcional ao tamanho da entrada.

* ![image](https://github.com/user-attachments/assets/03c0dc28-c084-43e0-b99f-c94e2b209cf4)
