function getRandomDieValue() {
    return Math.floor(Math.random() * 6) + 1;
}

async function rollDie(dieElement, modifier) {
    return new Promise(resolve => {
        const face = dieElement.querySelector('.dice-face');
        const result = getRandomDieValue();

        dieElement.classList.add('rolling');
        let animationCount = 0;

        const animationInterval = setInterval(() => {
            const randomValue = Math.floor(Math.random() * 6) + 1;
            face.textContent = String.fromCodePoint(0x2680 + randomValue - 1);
            animationCount++;

            if (animationCount > 10) {
                clearInterval(animationInterval);
                dieElement.classList.remove('rolling');

                face.textContent = String.fromCodePoint(0x2680 + result - 1);
                resolve(result + modifier);
            }
        }, 100);
    });
}

async function rollSkill() {
    document.getElementById('Skill').value = await rollDie(document.getElementById('skillDice'), 6);
}

async function rollLuck() {
    document.getElementById('Luck').value = await rollDie(document.getElementById('luckDice'), 6);
}

async function rollAll() {
    await Promise.all([rollSkill(), rollStamina(), rollLuck()]);
}

async function rollStamina() {
    const dice = document.querySelectorAll('#staminaDice .dice');
    const [die1, die2] = dice;

    const result = await Promise.all([
        rollDie(die1, 6),
        rollDie(die2, 6)
    ]);

    document.getElementById('Stamina').value = result.reduce((a, b) => a + b, 0);
}
