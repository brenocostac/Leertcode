# Busca Binária

Este projeto implementa o algoritmo de busca binária, uma forma eficiente de encontrar um elemento específico em um array (vetor) **ordenado**.

## Performance: Quão Rápido e Quanta Memória?

Ao analisar a "complexidade", avaliamos o desempenho do algoritmo em relação ao tamanho da entrada.

### Complexidade Temporal: O(log N) (Tempo Logarítmico)

A busca binária é extremamente eficiente e executa em tempo "logarítmico", ou $O(\text{log N})$, onde $N$ é o número de elementos no array. Isso significa que o tempo de execução cresce muito lentamente com o aumento do tamanho da entrada.

**Por quê?**
* Em cada etapa, o algoritmo divide o espaço de busca pela metade.
* Isso permite encontrar o elemento muito rapidamente, mesmo em arrays enormes. Por exemplo, em um array com um milhão de elementos, a busca binária levaria no máximo cerca de 20 passos.

### Complexidade Espacial: O(1) (Espaço Constante)

A complexidade de espaço é "constante", ou $O(1)$. Isso indica que a memória extra utilizada pelo algoritmo é mínima e não cresce com o tamanho do array.

**Por quê?**
* O algoritmo utiliza apenas algumas variáveis (`low`, `high`, `mid`) para controlar o processo de busca.
* A quantidade de memória usada por essas variáveis é a mesma, independentemente de o array ter 10 ou 10 milhões de elementos.

## Importante: Prevenindo Overflow no Cálculo do Meio (`mid`)

Ao calcular o índice do meio (`mid`) em uma busca binária, a fórmula aparentemente simples `(low + high) / 2` pode causar um **overflow** em linguagens como Java (e C#, C++) se os valores de `low` e `high` forem muito grandes (próximos ao limite máximo de um `int`). Isso ocorre porque a soma `low + high` pode exceder a capacidade do tipo `int` antes da divisão, resultando em um número negativo ou incorreto.

Para evitar esse problema, a maneira recomendada e segura de calcular `mid` é: