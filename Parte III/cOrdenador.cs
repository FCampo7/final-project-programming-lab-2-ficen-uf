using System;
using System.Collections.Generic;

namespace Parte_3_del_TP_de_LPII
{
    class cOrdenador // Clase que contiene todos los algoritmos Sort que vamos a utilizar.
    {
        public cOrdenador() { }

        public void burbujaSinContador(List<sFila> lista) { // Sort por método burbuja.
            sFila aux;
            for(int i = 0; i < lista.Count; i++) {
                for(int j = 0; j < lista.Count - 1 - i; j++) {
                    if(Convert.ToInt32(lista[j].C) > Convert.ToInt32(lista[j + 1].C)) {
                        aux = lista[j];
                        lista[j] = lista[j + 1];
                        lista[j + 1] = aux;
                    }
                }
            }
        }

        public int burbujaConContador(List<sFila> lista) { // Sort por método burbuja con contador.
            sFila aux;
            int cont = 0;
            for(int i = 0; i < lista.Count; i++) {
                for(int j = 0; j < lista.Count - 1 - i; j++) {
                    if(Convert.ToInt32(lista[j].C) > Convert.ToInt32(lista[j + 1].C)) { // Verificamos si el valor actual es mayor al siguiente y hacemos el cambio.
                        aux = lista[j];
                        lista[j] = lista[j + 1];
                        lista[j + 1] = aux;
                        cont++; // Aumentamos el contador de cambios.
                    }
                }
            }
            return cont;
        }

        public void ordenarInsert(List<sFila> lista) { // Sort por método insert.
            int j;
            sFila aux;

            for(int i = 1; i<lista.Count; i++) {
                j=i;
                aux=lista[j]; // Guardamos el elemento actual.

                while(j>0 && Convert.ToInt32(aux.C)<Convert.ToInt32(lista[j-1].C)) { // Comparamos el elemento actual con los anteriores. Si es menor efectuamos el cambio.
                    lista[j]=lista[j-1];
                    j--;
                }
                lista[j]=aux;
            }
        }

        public void QuickSort(List<sFila> lis) { //Función vórtice del método quickSort.
            QuickSort(lis, 0, lis.Count-1); // Pasamos el tamaño menos 1 por que evaluamos hasta la última posición, incluida, en el while.
                                            // Da errores de overflow de memoria si no.
        }

        private void QuickSort(List<sFila> lista, int primero, int ultimo) { // Sort por método quickSort.
            sFila aux;

            // Obtemenos el elemento central y su valor.
            int i = primero, j = ultimo, central = ((i+j)/2), pivote = Convert.ToInt32(lista[central].C);
            
            do {
                while(Convert.ToInt32(lista[i].C)<pivote) i++; // Aumentamos i hasta que el valor sea menor al pivote.
                while(Convert.ToInt32(lista[j].C)>pivote) j--; // Disminuimos j hasta que el valor sea mayor que el pivote.

                if(i<=j) { // Si la posicion i es menor o igual a la posicion j hacemos el cambio.
                    aux=lista[i];
                    lista[i]=lista[j];
                    lista[j]=aux;
                    // Aumentamos i y decrementamos j para no volver a evaluar el mismo valor.
                    i++;
                    j--;
                }
            } while(i<=j);

            if(primero<j) QuickSort(lista, primero, j); // Si la primera posición es menor que j llamamos otra vez a la función hasta que j sea menor o igual al primero. 
            if(ultimo>i) QuickSort(lista, i, ultimo); // Si la última posición es mayor que i llamamos otra vez a la función hasta que i sea mayor o igual al ultimo.
        }

        public void MergeSort(List<sFila> lis) { //Función vórtice del método MergeSort.
            MergeSort(lis, 0, lis.Count);
        }

        private void MergeSort(List<sFila> lista, int inicio, int final) {

            // Creamos un arreglo auxiliar del tipo de estructura definida en la FormParte3 con el tamaño de la lista.
            sFila[] aux = new sFila[lista.Count];

            // Obtenemos la posicion central.
            int centro = ((inicio+final)/2), i = inicio, j = centro, k;

            if((centro-inicio)>1) MergeSort(lista, inicio, centro); // Evaluamos por mitades hasta que solo haya un elemento.
            if((final-centro)>1) MergeSort(lista, centro, final);

            for(k=inicio; k<final; k++) { // Copiamos los datos de la lista en el arreglo auxiliar.
                aux[k]=lista[k];
            }

            k=inicio;

            while(i<centro && j<final) {
                // Si el valor en i es menor al valor en j entonces guardamos el valor de la pos i del array aux en la pos k de la lista.
                if(Convert.ToInt32(aux[i].C)<Convert.ToInt32(aux[j].C)) {
                    lista[k]=aux[i];
                    i++;
                }
                // Si no guardamos el valor de la posición j del array auxiliar en la posicion k de la lista.
                else {
                    lista[k]=aux[j];
                    j++;
                }
                k++;
            }
            // Copiamos el resto de los valores en la lista. (esto es porque en el while anterior una de las dos pos va a hacer salir).
            while(i<centro) { 
                lista[k]=aux[i];
                i++;
                k++;
            }
            while(j<final) {
                lista[k]=aux[j];
                j++;
                k++;
            }
        }
    }
}
