### **Trabajo Practico Nº 8**

#### **Objetos del tipo LinkedList y List, ¿Cuales son las diferencias que tienen?**

  _Los objetos del tipo **List** basicamente son arreglos que generalmente es mas grande que el numero de elementos que posee. Si se define un objeto del tipo List con espacio
para 10 elementos, una vez que se lleno, se crea otra lista pero con la consecuencia de que los elementos guardados en la anterior lista se pierden.
el acceso a cada elemento es rapido, ya que se accede mediante indice, pero para eliminar o insertar elementos al inicio o en otro lugar de la lista menos al final, tiene un 
costo de ejecucion lento, ahora si se quiere agregar o quitar un elemento al final de la lista, el costo de ejecucion es mucho mas rapido.
  Un objeto del tipo **LinkedList** es una lista doblemente enlazada. Cada nodo esta enlazado al nodo anterior y al siguiente, gracias a esto, se puede ingresar rapidamente
un nuevo nodo al principio de la lista, al final de la lista o antes o despues de un nodo en particular. El acceso a un elemento de la lista por el indice es lento.
  Otra diferencia es que un objeto del tipo LinkedList necesita mas memoria que un objeto del tipo List, debido a que necesita espacio para todas las referencias
anteriores/siguientes. Por otro lado, un objeto del tipo List puede tener un arreglo de respaldo que es mucho mas grande que sus necesidades actuales._


#### **Objeto del tipo Diccionario**

  _Un objeto de tipo diccionario es una coleccion de objetos generica que permite realizar busquedas y recuperaciones rapidas mediante la tecnica de key-value. 
Un objeto de tipo diccionario es muy util al momento de buscar informacion mediante una key de acceso, ya que el costo de ejecucion es minimo a comparacion de una lista.
Para agregar un valor a un diccionario es necesario asociarlo con una clave, la cual se usara para buscar dicho valor dentro del diccionario._


#### **Beneficios de usar una biblioteca, por que pondria una clase en una biblioteca y cuando agregaria directamente la clase en su proyecto**

_Usar una biblioteca de clases resulta beneficioso ya que se puede reutilizar el codigo que hay en ella en varios proyectos. Colocaria una clase en una biblioteca por ejemplo si en dos proyectos distintos, necesitaria cargar datos de un usuario y si necesito hacer uso de una clase que solo sirva para un proyecto especifico entonces agregaria la clase solo a ese proyecto._


#### **como se agrega la referencia a una biblioteca de clase en su proyecto**

__
