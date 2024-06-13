document.getElementById('msgerForm').addEventListener('submit', function (e) {
    e.preventDefault();

    // Gönderilen mesaj
    addMessage('right', messageText);

    document.getElementById('txtMessage').value = ' ';
});

function addMessage(side, text) {
    const msgContainer = document.createElement('div');
    msgContainer.classList.add('msg', side);

    const msgBubble = document.createElement('div');
    msgBubble.classList.add('msg-bubble');
    msgBubble.textContent = text;

    msgContainer.appendChild(msgBubble);
    document.getElementById('messageContainer').appendChild(msgContainer);

    msgContainer.scrollIntoView({ behavior: 'smooth' });
}
