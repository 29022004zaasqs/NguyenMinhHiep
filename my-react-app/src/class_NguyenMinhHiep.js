import React, { Component } from 'react'

 class Class_NguyenMinhHiep extends Component {
    constructor(props){
        super(props);
        this.state={
            fullName:"NguyenMinhHiep",
            class:"K22CNT1"
        }
    }
     users ={
        name:"NguyenMinhHiep",
        age: 20
    }
    // Hàm xử lý sk
    handleChange = (event)=>{
        this.setState({
            fullName:"NguyenMinhHiep",
        })
    }
  render() {
    return (
      <div>
            <h2>Class Component Demo</h2>
            {this.users.name} - {this.users.age}
            <hr/>
            <h3>info: {this.props.info}</h3>
            <h3>Time:{this.props.time}</h3>
            <hr/>
            <h3>State:
                FullName: {this.state.fullName}
                Class: {this.state.class}
            </h3>
            <button onClick={this.handleChange}>Change Name</button>
      </div>
    );
  }
}

export default Class_NguyenMinhHiep;