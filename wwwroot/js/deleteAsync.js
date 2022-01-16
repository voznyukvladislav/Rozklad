function deleteAsync(url, id, name) {
	const question = `Are you sure want to delete this ${name}`;
	const confirmDelete = confirm(question);
	if (confirmDelete) {
		$.ajax({
			type: "DELETE",
			url: url,
			async: false,
			data: {
				id: id
			},
			success: () => {
				document.location.reload();
			}
		})
	}
	return;
}