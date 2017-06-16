#include <iostream>
#include <cstdlib>
#include <cstring>
#include <cstdio>
#include <ctime>
#include <windows.h>
using namespace std;

void Guardar(char letra){
    FILE * pFile;

    pFile = fopen ("codigo.txt", "ab");
    fwrite (&letra , 1, sizeof(char), pFile);
    fclose (pFile);
}

string tostring(int i){
                                                 //   int to string en c++
    string num;
    int temp;
    while(i / 10!=0){
        temp=i%10;
        i= i/10;
        temp =temp + 48;
        num = (char)temp + num;
    }
    i=i+48;
    num = (char)i + num ;
    return num;
}


int main(){

    srand(time(NULL));
    for(int k=0;k<120;k++){
        string sql1="INSERT INTO tripulantes(tipo_TCP, nombre_TCP, apellido_TCP, cuil_TCP, telefono_TCP) \r\n VALUES ('aux', '";
        string numero1=tostring(rand()%89999+10000);
        string numero2=tostring(rand()%89999+10000);
        string numero3=tostring(rand()%89999+10000);
        string numero4=tostring(rand()%89999+10000);




        string nombres[]{"Pedro", "David", "Monica", "Emmanuel", "María", "Mateo", "Damian", "Franco", "Lucila", "Ludmila", "Carlos", "Cristian", "Alberto" , "Marcelo", "Ana", "Raul", "Matías", "José", "Antonio", "Carmen", "Lucas", "Ismaél", "Rubén", "Andrés", "Patricia", "Lugo", "Esther", "Lucia", "Miguel", "Ariel", "Jesús"}; ///31
        string apellidos[]{"Gomez", "Rodriguez", "Lopez", "Musiani", "Montero", "Bañez", "Perez", "Montenegro", "Zapatero", "Rufián", "Radnikov", "de Lourdes", "Herrera", "Molina", "Smith", "Fernandez", "Luna", "Candela", "Maldonado", "Pogonza", "Del Bueno", "Fuertez", "Pinto", "Correa", "Cardenas", "Gutierrez", "Lapido", "Borbón", "Buenafuente", "Estias"}; ///30


        string texto=sql1+nombres[rand()%31]+"', '"+apellidos[rand()%30]+"', '"+numero1+numero2+"', '"+numero3+numero4+"') \r\n";

        int j=0;
        while (texto[j]!='\0')j++;
        cout<<j;

        for(int i=0;i<j;i++){

            Guardar(texto[i]);
        }

    }
    ///system("pause");
    return 0;
}
