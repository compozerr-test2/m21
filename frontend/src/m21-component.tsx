import React from "react";

interface Props {
   name: string;
}

const M21Component = (props: Props) => {
   return (
      <div>
         Hello {props.name}
      </div>
   );
}

export default M21Component;