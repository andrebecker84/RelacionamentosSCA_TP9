<p align="center">
  <img src="https://github.com/andrebecker84/AppWebASPNETcoreTP2/assets/39974878/2c3a2ab1-5789-47d3-ade6-e300e2b8af69">
</p>
<br>

<p align="center">PROJETO DE BLOCO: DESENVOLVIMENTO BACK-END</p>

<p align="center">Teste de Performance - TP9</p>

<p align="center">
  <img src="https://github.com/andrebecker84/RelacionamentosSCA_TP9/assets/39974878/f7359664-5446-4a31-a3e2-87218c1c7ecc">
  <img src="https://github.com/andrebecker84/RelacionamentosSCA_TP9/assets/39974878/aa663cff-8496-4a8f-8333-449d1e347055">
</p>


---

## ENUNCIADO

1. Faça uma revisão no Diagrama de Classes (DC) do Sistema de Controle Acadêmico (SCA), verificando se todas as classes necessárias foram especificadas, se as multiplicidades estão corretas e, principalmente, se os principais atributos e métodos de cada classe foram especificados. Quando tratamos de revisão de atributos e métodos, o objetivo é a codificação do DC em uma linguagem de programação.

3. Seria possível reutilizar a modelagem do SCA, pensando especificamente no caso do sistema acadêmico do Infnet?
   Quais as mudanças seriam necessárias na especificação do sistema?

4. Seria possível implementar o SCA utilizando uma arquitetura Model-View-Controller (MVC)?
   Dê um exemplo de CRUD (Create, Read, Update e Delete) que poderia ser aplicado em uma das classes do DC utilizando o MVC.

5. Implemente as classes Aluno, Professor, Disciplina e Turma a partir do Diagrama de Classes (DC) abaixo, que não representa exatamente o minimundo do SCA, apresentado anteriormente.
   O DC omitiu os métodos get, set e toString das classes.

<p align="center">
<img src="https://github.com/andrebecker84/RelacionamentosSCA_TP9/assets/39974878/9c97b5fc-577f-40a5-97d5-0c8ef4779e6c">
</p>

Agora, o DC permite que um aluno possa estar alocado em mais de uma turma, porém professores e disciplinas devem estar alocados em apenas uma turma. 

* A classe Aluno possui dois métodos: addTurma e exibirTurmas.
* O método addTurma permite incluir um aluno em uma determinada turma e o método exibirTurmas permite exibir todas as turmas que o aluno está cursando.
* Além de criar as classes com base no DC, faça um programa em Java ou C# que implemente as funcionalidades dos métodos addTurma e exibirTurmas.
* Para simplificar os testes, assuma que o programa não fará a alocação de professores e disciplinas em mais de uma turma.
* Outra dica é criar quatro listas: turmas, professores, disciplinas e alunos.
* Adicione os objetos nas listas, implementando os relacionamentos necessários, e depois faça os testes com os métodos addTurma e exibirTurmas.
