﻿using Microsoft.AspNetCore.Components;

namespace MiniPerson.Endpoints.Shared.Modals.Components
{
    public partial class Modal : ComponentBase
    {
        [Parameter]
        public RenderFragment Title { get; set; }

        [Parameter]
        public RenderFragment Body { get; set; }

        [Parameter]
        public RenderFragment Footer { get; set; }

        private string modalDisplay = "none;";
        private string modalClass = "";
        private bool showBackdrop = false;

        public void Open()
        {
            modalDisplay = "block;";
            modalClass = "show";
            showBackdrop = true;
        }

        public void Close()
        {
            modalDisplay = "none";
            modalClass = "";
            showBackdrop = false;
        }
    }
}
