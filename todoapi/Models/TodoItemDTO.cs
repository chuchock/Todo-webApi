using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace todoapi.Models
{
	public class TodoItemDTO
	{
		/*
			A DTO (data transfer object) may be used to:

			Prevent over-posting.
			Hide properties that clients are not supposed to view.
			Omit some properties in order to reduce payload size.
			Flatten object graphs that contain nested objects. Flattened object graphs can be more convenient for clients.
		 */
		public long Id { get; set; }
		public string Name { get; set; }
		public bool IsComplete { get; set; }
	}
}
