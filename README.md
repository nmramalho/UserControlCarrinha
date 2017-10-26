# UserControlCarrinha
Componente do tipo User Control que forneça uma interface gráfica para a reserva de lugares em carrinhas com capacidade para seis passageiros. Os lugares dos passageiros (6) e motorista (1) são representados por botões.

# Funcionamento dos botões da interface:
-	Ao clicar nos botões referentes aos passageiros estes devem alternar a cor e texto (verde – Livre, azul - ocupado).
-	O botão relativo ao motorista deve alternar entre preto – SIM, cinza – NÃO.
-	Deverá existir um botão para colocar todos os lugares no estado Livre e motorista no estado NÃO.
-	Só é possivel reservar lugares depois de ser atribuido um motorista.

Nota: Imagem do autocarro disponível em: https://pixabay.com/p-310766/?no_redirect
 
 # Tipo de projeto: Visual C#, Class Library (.NET Framework) 

- Nome do projeto: ClassLibraryCarrinha.
- O projeto deve ser constituído por um elemento User Control de nome UserControlCarrinhaSeteLugares.
-	A classe deve ter os atributos:
  o	MotoristaAtribuido (bool)
  o	NumLugaresLivres (int)
  o	NumeroLugaresReservados(int)
-	Os valores dos atributos devem ser atualizados de acordo com estado dos botões.

