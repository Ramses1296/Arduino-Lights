int led = 13;
int boton = 10;
int prender;

void setup() {
  pinMode(led,OUTPUT);
  pinMode(boton,INPUT);
  
  digitalWrite(led,LOW);
}

void loop() {
  //Recuperamos el estado del botón
  prender = digitalRead(boton);
  
 if(prender == HIGH){
   digitalWrite(led,HIGH);

 } else{
   digitalWrite(led,LOW);
 }
}
