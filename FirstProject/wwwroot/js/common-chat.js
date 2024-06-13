document.getElementById('msgerForm').addEventListener('submit', function(e) {
    e.preventDefault();

    const messageText = document.getElementById('txtMessage').value.trim();
    
    if (messageText !== '') {
        // Gönderilen mesaj
        addMessage('right', messageText);
    }
    
    document.getElementById('txtMessage').value = '';

    // Simülasyon için botun yanıtını eklemek için bu kısmı isteğe bağlı olarak ekleyebilirsiniz:
    // Botun yanıtını buraya eklemek için addMessage fonksiyonunu çağırabilirsiniz.
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
