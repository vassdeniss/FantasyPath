const elements = {
    skill: document.getElementById('Skill'),
    stamina: document.getElementById('Stamina'),
    luck: document.getElementById('Luck'),
    enemySkill: document.getElementById('enemySkill'),
    enemyStamina: document.getElementById('enemyStamina'),
    currentEnemyStamina: document.getElementById('currentEnemyStamina'),
    combatLog: document.getElementById('combatLog'),
    useLuckBtn: document.getElementById('useLuckBtn')
};

let currentCombat = {
    isActive: false,
    enemySkill: 0,
    initialEnemyStamina: 0,
    currentEnemyStamina: 0,
    lastDamage: 0
};

function startCombat() {
    const enemySkill = parseInt(elements.enemySkill.value);
    const enemyStamina = parseInt(elements.enemyStamina.value);

    if (!enemySkill || !enemyStamina) {
        alert("Please enter enemy Skill and Stamina!");
        return;
    }

    if (currentCombat.isActive) {
        performCombatRound();
        return;
    }

    currentCombat = {
        isActive: true,
        enemySkill,
        initialEnemyStamina: enemyStamina,
        currentEnemyStamina: enemyStamina,
        lastDamage: 0
    };

    elements.currentEnemyStamina.value = enemyStamina;
    elements.combatLog.style.display = 'block';
    elements.combatLog.innerHTML = '';
    performCombatRound();
}

function roll2d6() {
    return Math.floor(Math.random() * 6 + 1) + Math.floor(Math.random() * 6 + 1);
}

function updateCombatLog(message) {
    elements.combatLog.insertAdjacentHTML('afterbegin',
        `<div class="combat-log-entry">${message}</div>`
    );
}

function takeHealth(currentHealth, amount, element) {
    const newHealth = Math.max(currentHealth - amount, 0);
    elements[element].value = newHealth;
    return newHealth;
}

function performCombatRound() {
    if (!currentCombat.isActive) return;

    const playerRoll = roll2d6();
    const enemyRoll = roll2d6();
    const playerSkill = parseInt(elements.skill.value);
    const playerStamina = parseInt(elements.stamina.value);
    const playerTotal = playerSkill + playerRoll;
    const enemyTotal = currentCombat.enemySkill + enemyRoll;

    let logEntry = `<div class="combat-round mb-2">
            <div>Player: ${playerRoll} Roll + ${playerSkill} Skill = <strong>${playerTotal}</strong></div>
            <div>Enemy: ${enemyRoll} Roll + ${currentCombat.enemySkill} Skill = <strong>${enemyTotal}</strong></div>`;

    if (playerTotal > enemyTotal) {
        currentCombat.currentEnemyStamina = takeHealth(currentCombat.currentEnemyStamina, 2, 'currentEnemyStamina');
        logEntry += `<div class="text-success">You strike the enemy! (-2 Stamina)</div>`;
        currentCombat.lastDamage = 0;

        if (currentCombat.currentEnemyStamina <= 0) {
            logEntry += `<div class="text-success fw-bold">ENEMY DEFEATED!</div>`;
            resetCombat();
        }
    } else if (enemyTotal > playerTotal) {
        const newStamina = takeHealth(playerStamina, 2, 'stamina');
        logEntry += `<div class="text-danger">Enemy hits you! (-2 Stamina)</div>`;
        currentCombat.lastDamage = 2;

        if (newStamina <= 0) {
            logEntry += `<div class="text-danger fw-bold">GAME OVER! YOU HAVE DIED!</div>`;
            resetCombat();
        }
    } else {
        logEntry += `<div class="text-muted">Clash! No damage dealt</div>`;
    }

    logEntry += `</div>`;
    updateCombatLog(logEntry);
    updateCombatControls();
}

function flee() {
    currentCombat.lastDamage = 2;
    const playerStamina = parseInt(elements.stamina.value);
    const newStamina = takeHealth(playerStamina, 2, 'stamina');

    let logEntry = `<div class="combat-round mb-2">
            <div class="text-info">You flee battle! (-2 Stamina)</div>`;

    if (playerStamina - 2 <= 0) {
        logEntry += `<div class="text-danger fw-bold">GAME OVER! YOU HAVE DIED!</div>`;
        resetCombat();
    } else {
        logEntry += `<div>Escaped with ${newStamina} Stamina remaining</div>`;
        updateCombatControls();
    }

    logEntry += `</div>`;
    updateCombatLog(logEntry);
}

function testLuck() {
    const luck = parseInt(elements.luck.value);
    const luckRoll = roll2d6();
    let logEntry = `<div class="combat-round mb-2">Luck Test: ${luckRoll} `;

    if (luckRoll <= luck) {
        logEntry += "(Success!) ";

        if (currentCombat.lastDamage > 0) {
            takeHealth(parseInt(elements.stamina.value), -1, 'stamina');
            logEntry += `<div class="text-success">The blow was weak! (+1 Stamina)</div>`;
        } else {
            currentCombat.currentEnemyStamina = takeHealth(currentCombat.currentEnemyStamina, 2, 'currentEnemyStamina');
            logEntry += `<div class="text-success">You strike the enemy for more damage! (-2 Stamina)</div>`;
        }
    } else {
        logEntry += "(Failure!) ";

        if (currentCombat.lastDamage > 0) {
            takeHealth(parseInt(elements.stamina.value), 1, 'stamina');
            logEntry += `<div class="text-danger">That blow went deep! (-1 Stamina)</div>`;
        } else {
            currentCombat.currentEnemyStamina = takeHealth(currentCombat.currentEnemyStamina, -1, 'currentEnemyStamina');
            logEntry += `<div class="text-danger">You stumble and only graze it! (+1 Stamina)</div>`;
        }
    }

    elements.luck.value = luck - 1;

    if (currentCombat.currentEnemyStamina <= 0) {
        logEntry += `<div class="text-success fw-bold">ENEMY DEFEATED!</div>`;
        resetCombat();
    } else if (parseInt(document.getElementById('Stamina').value) <= 0) {
        logEntry += `<div class="text-danger fw-bold">GAME OVER! YOU HAVE DIED!</div>`;
        resetCombat();
    }

    logEntry += `</div>`;
    updateCombatLog(logEntry);
    updateCombatControls();
}

function resetCombat() {
    currentCombat.isActive = false;
    elements.currentEnemyStamina.value = '';
    elements.combatLog.innerHTML = '';
    elements.enemySkill.value = '';
    elements.enemyStamina.value = '';
}

function updateCombatControls() {
    elements.useLuckBtn.disabled = parseInt(elements.luck.value) < 1 || !currentCombat.isActive;
}
