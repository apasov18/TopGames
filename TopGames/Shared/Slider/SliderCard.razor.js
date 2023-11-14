export class SliderCard
{
    static SetTimeout(component, slide) {
        let mouseenter = false;
        let timeout = false;


        function MouseEnter() {
            mouseenter = true;

        }
        function MouseLeave() {
            mouseenter = false;
            if (timeout) {

                Next();
            }

        }

        function Next() {
            slide.addEventListener("mouseenter", MouseEnter)
            slide.addEventListener("mouseleave", MouseLeave)
            component.invokeMethodAsync("Next");
        }

        slide.addEventListener("mouseenter", MouseEnter)
        slide.addEventListener("mouseleave", MouseLeave)

        setTimeout(() => {
            timeout = true;
            if (!mouseenter) {
                Next();

            }
        }, 5300)

    }

    
}