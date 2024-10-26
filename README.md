# Validação de Formatos de Data e Hora em C#

Este programa em C# permite ao usuário visualizar a data e hora atual em diferentes formatos personalizados, oferecendo quatro opções de exibição. É uma aplicação simples e que fiz como exercício que demonstra o uso de formatação de data e hora usando o `DateTime` e o `ToString` com expressões de formatação específicas.

## Funcionalidades

O programa apresenta as seguintes opções de exibição da data e hora atuais:

1. **Formato Completo**  
   Exibe o dia da semana, dia do mês, nome completo do mês, ano, hora, minutos e segundos (formato 24 horas).  
   **Exemplo:** `sexta-feira, 26 de outubro de 2024, 15:30:45`

2. **Data no Formato Padrão (DD/MM/AAAA)**  
   Mostra apenas a data no formato padrão brasileiro: `dd/MM/yyyy`.  
   **Exemplo:** `26/10/2024`

3. **Hora Completa (Formato 24 horas)**  
   Mostra apenas a hora, minutos e segundos no formato de 24 horas: `HH:mm:ss`.  
   **Exemplo:** `15:30:45`

4. **Data com Mês por Extenso**  
   Exibe a data com o dia, mês por extenso e ano.  
   **Exemplo:** `26 de outubro de 2024`

## Estrutura do Código

- O programa utiliza o método `DateTime.Now` para obter a data e hora atuais do sistema.
- Cada opção de exibição usa `ToString` com formatos específicos para gerar a string formatada.
- A classe `CultureInfo("pt-BR")` é aplicada para garantir que os nomes de dias e meses estejam em português.

## Como Usar

1. Clone este repositório.
2. Compile e execute o programa.
3. Escolha uma das opções de exibição digitando o número correspondente.
4. A data e/ou hora no formato selecionado será exibida no console.

### O programa está [aqui](https://github.com/RuanVNBezerra/Exercicio_3/blob/master/Exercicio_3/Program.cs)
