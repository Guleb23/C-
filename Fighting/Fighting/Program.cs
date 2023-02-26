int playerHealth = 100;
int playerDamage = 10;
int enemyHealth = 100;
int enemyDamage = 10;
while( playerHealth> 0 && enemyHealth> 0)
{
    playerHealth -= enemyDamage;
    enemyHealth -= playerDamage;
    Console.WriteLine($"Игрок имеет {playerHealth} здоровья");
    Console.WriteLine($"Враг имеет {enemyHealth} здоровья");
}
if (playerHealth <= 0 && enemyHealth <= 0)
{
    Console.WriteLine("None");
}
else if (playerHealth >= 0 && enemyHealth <= 0)
{
    Console.WriteLine("Player victory");
}
else if (playerHealth <= 0 && enemyHealth >= 0)
{
    Console.WriteLine("Enemy victory");
}