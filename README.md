Desafio: Caixa Eletrônico
Link: http://dojopuzzles.com/problemas/exibe/caixa-eletronico/
Descrição:
Desenvolva um programa que simule a entrega de notas quando um cliente efetuar um saque em um
caixa eletrônico. Os requisitos básicos são os seguintes:
• Entregar o menor número de notas;
• É possível sacar o valor solicitado com as notas disponíveis;
• Saldo do cliente infinito;
• Quantidade de notas infinito (pode-se colocar um valor finito de cédulas para aumentar a
dificuldade do problema);
• Notas disponíveis de R$ 100,00; R$ 50,00; R$ 20,00 e R$ 10,00


- Criado um repositório chamado CaixaEletronico;
- Criada uma interface (ICaixa) com o método de RealizarSaque(int valor);
- Criada uma classe que implementa ICaixa (a Caixa);



* Casos de Teste
- Realizada a criação de um projeto de teste com o nome de CaixaEletronicoTeste.
- Foram criados alguns métodos para testarem as cédulas:



public void TesteValorInvalido();
- Descrição: Retorna quando um valor é inválido. Considerado valores iguais ou menores do que zero.

public void TesteCedulaIndisponivel();
- Descrição: Verifica se um valor pedido está impossível de sacar, de acordo com as cédulas disponíveis.
       
public void TesteNotaCem()
- Descrição: Verifica quantidade de cédulas de "R$ 100" são utilizadas para o saque.
        
public void TesteNotaCinquenta()
- Descrição: Verifica quantidade de cédulas de "R$ 50" são utilizadas para o saque.
        
public void TesteNotaVinte()
- Descrição: Verifica quantidade de cédulas de "R$ 100" são utilizadas para o saque.
        
public void TesteNotaDez()
- Descrição: Verifica quantidade de cédulas de "R$ 100" são utilizadas para o saque.
        
public void TestaNotas1()
- Descrição: Verifica quantidade de cédulas de "R$ 100" e "R$ 50" são utilizadas para o saque.
        
public void TestaNotas2()
- Descrição: Verifica quantidade de cédulas de "R$ 100", "R$ 50" e "R$ 20" são utilizadas para o saque.
        
public void TestaNotas3()
- Descrição: Verifica quantidade de cédulas de "R$ 100", "R$ 50", "R$ 20" e "R$ 10" são utilizadas para o saque.
        
public void TestaNotas4()
- Descrição: Verifica N cédulas de "R$ 100", "R$ 50", "R$ 20" e "R$ 10" são utilizadas para o saque.

public void TestaNotas5()
- Descrição: Verifica a quantidade cédulas de "R$ 50" e "R$ 10" são utilizadas para o saque.

public void TestaNotas6()
- Descrição: Verifica N cédulas de "R$ 100" e "R$ 10" são utilizadas para o saque.

public void TestaNotas7()
- Descrição: Verifica N cédulas de "R$ 50" e "R$ 20" são utilizadas para o saque.
