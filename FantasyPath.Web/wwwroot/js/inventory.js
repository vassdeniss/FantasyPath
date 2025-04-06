function addInventoryItem() {
    const input = document.getElementById('newInventoryItem');
    const itemValue = input.value.trim();

    if (itemValue) {
        const inventoryDiv = document.getElementById('inventoryItems');

        const newItem = document.createElement('div');
        newItem.className = 'inventory-item d-inline-block me-2 mb-2';
        newItem.innerHTML = `
                    <div class="input-group">
                        <span class="input-group-text bg-light">${itemValue}</span>
                        <button type="button" class="btn btn-danger" onclick="removeInventoryItem(this)">
                            <i class="bi bi-x"></i>
                        </button>
                        <input type="hidden" name="Inventory" value="${itemValue}" />
                    </div>
                `;

        inventoryDiv.appendChild(newItem);
        input.value = '';
    }
}

function removeInventoryItem(button) {
    const itemDiv = button.closest('.inventory-item');
    itemDiv.remove();
}
