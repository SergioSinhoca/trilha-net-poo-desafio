# DIO - Trilha .NET - Programação orientada a objetos
www.dio.me

## Desafio de projeto
Para este desafio, você precisará usar seus conhecimentos adquiridos no módulo de orientação a objetos, da trilha .NET da DIO.

## Contexto
Você é responsável por modelar um sistema que trabalha com celulares. Para isso, foi solicitado que você faça uma abstração de um celular e disponibilize maneiras de diferentes marcas e modelos terem seu próprio comportamento, possibilitando um maior reuso de código e usando a orientação a objetos.

## Proposta
Você precisa criar um sistema em .NET, do tipo console, mapeando uma classe abstrata e classes específicas para dois tipos de celulares: Nokia e iPhone. 
Você deve criar as suas classes de acordo com o diagrama abaixo:

![Diagrama classes](Imagens/diagrama.png)

## Regras e validações
1. A classe **Smartphone** deve ser abstrata, não permitindo instanciar e servindo apenas como modelo.
2. A classe **Nokia** e **Iphone** devem ser classes filhas de Smartphone.
3. O método **InstalarAplicativo** deve ser sobrescrito na classe Nokia e iPhone, pois ambos possuem diferentes maneiras de instalar um aplicativo.

## Solução
Minhas implementações para resolução deste desafio.

### Versão da Plataforma
- Este projeto foi desenvolvido utilizando a plataforma `.NET versão 8`.

## Implementações Realizadas
**1. Classe Abstrata Smartphone**

- **Problema resolvido:** Propriedades necessárias para o funcionamento do sistema estavam ausentes.

- **Implementação:** Implementei as propriedades `Modelo`, `IMEI` e `Memoria` que estavam faltando. Além disso, modifiquei o construtor para passar corretamente os parâmetros para essas propriedades.

**2.  Classe iPhone**

- **Problema resolvido:** Necessidade de implementar o comportamento específico para o iPhone.

- **Implementação:**  A classe `iPhone` herdou de `Smartphone` e sobrescrevi o método abstrato `InstalarAplicativo`, além de ajustar o construtor herdado para receber os parâmetros corretos.


**3. Classe Nokia**

- **Problema resolvido:**  Necessidade de implementar o comportamento específico para o Nokia

- **Implementação:** Assim como na classe `iPhone`, a classe `Nokia` herdou de `Smartphone`, e sobrescrevi o método abstrato `InstalarAplicativo`. Também utilizei o construtor herdado para passar os parâmetros.

**4. Classe Program**

- **Testes realizados:**  Na classe `Program`, criei instâncias das classes `Nokia` e `iPhone`. Testei o funcionamento dos métodos `Ligar` e `InstalarAplicativo`, passando os parâmetros necessários pelos construtores, garantindo o funcionamento correto das funcionalidades implementadas.

## Demonstração do Sistema

Aqui está uma breve demonstração em vídeo do sistema em execução: 

 <p align="center">
    <img src="video.gif">
 </p>
